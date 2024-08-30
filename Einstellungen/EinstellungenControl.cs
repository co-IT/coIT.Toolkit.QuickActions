using System.Diagnostics;
using coIT.Libraries.Clockodo.Account;
using coIT.Libraries.ConfigurationManager;
using coIT.Libraries.Toolkit.Datengrundlagen.Konten;
using coIT.Libraries.Toolkit.Datengrundlagen.Kunden;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using coIT.Toolkit.QuickActions.Einstellungen;
using CSharpFunctionalExtensions;

namespace coIT.Clockodo.QuickActions.Einstellungen
{
    public partial class EinstellungenControl : UserControl
    {
        private ClockodoEinstellungen _clockodoEinstellungen;
        private LexofficeKonfiguration _lexofficeKonfiguration;

        private EnvironmentManager _environmentManager;
        private FileSystemManager _fileSystemManager;

        internal delegate void EinstellungenGeladenEventHandler(
            object sender,
            EinstellungenGeladenEventArgs e
        );
        internal event EinstellungenGeladenEventHandler EinstellungenErfolreichGeladen;
        internal event EventHandler EinstellungenKonntenNichtGeladenWerden;

        internal event EventHandler EinstellungenAktualisierungStart;
        internal event EventHandler EinstellungenAktualisierungEnde;

        public EinstellungenControl(
            EnvironmentManager environmentManager,
            FileSystemManager fileSystemManager
        )
        {
            InitializeComponent();

            _environmentManager = environmentManager;
            _fileSystemManager = fileSystemManager;
        }

        public void Laden()
        {
            EinstellungenLaden();
        }

        private async void EinstellungenLaden()
        {
            var clockodoResult = await ClockodoEinstellungenLaden();
            var lexofficeResult = await LexofficeEinstellungenLaden();

            var einstellungenLadenResult = Result.Combine(clockodoResult, lexofficeResult);

            if (einstellungenLadenResult.IsFailure)
            {
                EinstellungenKonntenNichtGeladenWerden?.Invoke(this, new());
                MessageBox.Show(
                    einstellungenLadenResult.Error,
                    "Laden der Einstellungen fehlgeschlagen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                EinstellungenErfolreichGeladen?.Invoke(
                    this,
                    new EinstellungenGeladenEventArgs
                    {
                        ClockodoEinstellungen = _clockodoEinstellungen,
                        LexofficeEinstellungen = _lexofficeKonfiguration,
                    }
                );
            }
        }

        private async Task<Result> ClockodoEinstellungenLaden()
        {
            var konfigurationLadenErgebnis = await _environmentManager.Get<ClockodoEinstellungen>();

            if (konfigurationLadenErgebnis.IsFailure)
            {
                return Result.Failure(
                    $"Es muss eine Konfiguration für Clockodo durchgeführt werden"
                );
            }

            _clockodoEinstellungen = konfigurationLadenErgebnis.Value;
            ClockodoEinstellungenAnzeigen();
            return Result.Success();
        }

        private async void btnClockdoEinstellungenSpeichern_Click(object sender, EventArgs e)
        {
            EinstellungenAktualisierungStart?.Invoke(this, new());
            await ClockodoEinstellungenPrüfenUndSpeichern();

            EinstellungenAktualisierungEnde?.Invoke(this, new());
            EinstellungenLaden();
        }

        private async Task ClockodoEinstellungenPrüfenUndSpeichern()
        {
            var neueEinstellungen = new ClockodoEinstellungen
            {
                ApiToken = tbxClockodoApiKey.Text,
                EmailAddress = tbxClockodoEmail.Text,
            };

            var einstellungenSindValide = await ClockodoEinstellungenTesten(neueEinstellungen);

            if (!einstellungenSindValide)
            {
                MessageBox.Show(
                    $"Die eingegebene Clockodo Konfiguration ist unzulässig.{Environment.NewLine}"
                        + "Bitte kopiere erneut E-Mail und Api-Key.",
                    "Hinweis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var speicherErgebnis = await _environmentManager.Save(neueEinstellungen);

            if (speicherErgebnis.IsFailure)
            {
                MessageBox.Show(
                    speicherErgebnis.Error,
                    "Hinweis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MessageBox.Show(
                "Clockodo Konfiguration erfolgreich gespeichert",
                "Hinweis",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private async Task ClockodoEinstellungenAnzeigen()
        {
            tbxClockodoApiKey.Text = _clockodoEinstellungen.ApiToken;
            tbxClockodoEmail.Text = _clockodoEinstellungen.EmailAddress;
        }

        private async Task<bool> ClockodoEinstellungenTesten(ClockodoEinstellungen settings)
        {
            try
            {
                var testService = new AccountService(settings.CreateApiConnectionSettings);
                var accountInformationen = await testService.GetMyAccount();
                return accountInformationen is not null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<Result> LexofficeEinstellungenLaden()
        {
            var lexofficeKeyGesetzt = await _environmentManager.Get<LexofficeKonfiguration>();

            if (!lexofficeKeyGesetzt.IsSuccess)
                return Result.Failure(
                    $"Der Lexoffice Key konnte nicht in den Umgebungsvariablen gefunden werden. Bitte kontaktiere Jan"
                );

            _lexofficeKonfiguration = lexofficeKeyGesetzt.Value;
            tbxLexofficeApiToken.Text = _lexofficeKonfiguration.LexofficeKey;

            return Result.Success();
        }

        private async Task<Result> LexofficeEinstellungenSpeichern()
        {
            var lexofficeToken = tbxLexofficeApiToken.Text;

            var konfiguration = new LexofficeKonfiguration(lexofficeToken);

            // Da der Lexoffice Key in Zukunft automatisch ausgerollt wird, muss ein normaler Anwender nie selber den Lexoffice key abspeichern
#if DEBUG
            var konfigurationSpeichernErgebnis = await _environmentManager.Save(konfiguration);
#else
            var konfigurationSpeichernErgebnis = Result.Success();
#endif

            if (konfigurationSpeichernErgebnis.IsFailure)
            {
                MessageBox.Show(
                    "Fehler beim Speichern Lexoffice Konfiguration. Bitte erneut versuchen."
                );
                Application.Exit();
            }

            MessageBox.Show(
                "Lexoffice Konfiguration erfolgreich gespeichert",
                "Hinweis",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            return Result.Success();
        }

        private void LinkInBrowserÖffnen(string link)
        {
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        private void lnkClockodo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkInBrowserÖffnen(((Control)sender).Text);
        }

        private async void btnLexofficeEinstellungenSpeichern_Click(object sender, EventArgs e)
        {
            EinstellungenAktualisierungStart?.Invoke(this, new());
            await LexofficeEinstellungenSpeichern();

            EinstellungenAktualisierungEnde?.Invoke(this, new());
            EinstellungenLaden();
        }
    }
}
