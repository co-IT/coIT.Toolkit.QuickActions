using System.Diagnostics;
using coIT.Libraries.Clockodo.Account;
using coIT.Libraries.ConfigurationManager;
using coIT.Libraries.ConfigurationManager.Cryptography;
using coIT.Toolkit.QuickActions.Einstellungen;
using coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.DatabaseKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;
using CSharpFunctionalExtensions;

namespace coIT.Clockodo.QuickActions.Einstellungen;

public partial class EinstellungenControl : UserControl
{
    private static readonly string CoitToolkitQuickactionsClockodoEnvironmentKey =
        "COIT_TOOLKIT_QUICKACTIONS_CLOCKODO";
    private ClockodoEinstellungen _clockodoEinstellungen;
    private DatabaseEinstellungen _databaseEinstellungen;
    private LexofficeEinstellungen _lexofficeEinstellungen;

    private readonly EnvironmentManager _environmentManager;
    private readonly AesCryptographyService _cryptographer;

    public EinstellungenControl(
        EnvironmentManager environmentManager,
        AesCryptographyService cryptographer
    )
    {
        InitializeComponent();

        _environmentManager = environmentManager;
        _cryptographer = cryptographer;
    }

    internal event EinstellungenGeladenEventHandler EinstellungenErfolreichGeladen;
    internal event EventHandler EinstellungenKonntenNichtGeladenWerden;

    internal event EventHandler EinstellungenAktualisierungStart;
    internal event EventHandler EinstellungenAktualisierungEnde;

    public void Laden()
    {
        EinstellungenLaden();
    }

    private async void EinstellungenLaden()
    {
        var clockodoResult = await ClockodoEinstellungenLaden();
        var databaseResult = await DatabaseEinstellungenLaden();
        var lexOfficeResult = await LexofficeEinstellungenLaden();

        var einstellungenLadenResult = Result.Combine(
            clockodoResult,
            databaseResult,
            lexOfficeResult
        );

        if (einstellungenLadenResult.IsFailure)
        {
            EinstellungenKonntenNichtGeladenWerden.Invoke(this, EventArgs.Empty);
            MessageBox.Show(
                einstellungenLadenResult.Error,
                "Laden der Einstellungen fehlgeschlagen",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
        else
        {
            EinstellungenErfolreichGeladen.Invoke(
                this,
                new EinstellungenGeladenEventArgs
                {
                    ClockodoEinstellungen = _clockodoEinstellungen,
                    DatabaseEinstellungen = _databaseEinstellungen,
                    LexofficeEinstellungen = _lexofficeEinstellungen,
                }
            );
        }
    }

    private async Task<Result> DatabaseEinstellungenLaden()
    {
        return await _environmentManager
            .Get<DatabaseEinstellungen>("COIT_TOOLKIT_DATABASE_CONNECTIONSTRING")
            .Tap(einstellungen => _databaseEinstellungen = einstellungen)
            .TapError(fehler =>
                MessageBox.Show(
                    $"Datenbankzugang konnte nicht geladen werden: {fehler}",
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            );
    }

    private async Task<Result> LexofficeEinstellungenLaden()
    {
        return await Result
            .Success(_databaseEinstellungen)
            .Map(konfiguration => new LexofficeKonfigurationDataTableRepository(
                konfiguration.ConnectionString,
                _cryptographer
            ))
            .Bind(lexofficeRepository => lexofficeRepository.Get())
            .Tap(settings => _lexofficeEinstellungen = settings)
            .TapError(fehler =>
                MessageBox.Show(
                    $"Lexoffice Konfiguration konnte nicht geladen werden: {fehler}",
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            );
    }

    private async Task<Result> ClockodoEinstellungenLaden()
    {
        var konfigurationLadenErgebnis = await _environmentManager.Get<ClockodoEinstellungen>(
            CoitToolkitQuickactionsClockodoEnvironmentKey
        );

        if (konfigurationLadenErgebnis.IsFailure)
            return Result.Failure("Es muss eine Konfiguration für Clockodo durchgeführt werden");

        _clockodoEinstellungen = konfigurationLadenErgebnis.Value;
        ClockodoEinstellungenAnzeigen();

        return Result.Success();
    }

    private async void btnClockdoEinstellungenSpeichern_Click(object sender, EventArgs e)
    {
        EinstellungenAktualisierungStart?.Invoke(this, EventArgs.Empty);
        await ClockodoEinstellungenPrüfenUndSpeichern();

        EinstellungenAktualisierungEnde.Invoke(this, EventArgs.Empty);
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

        var speicherErgebnis = await _environmentManager.Save(
            neueEinstellungen,
            CoitToolkitQuickactionsClockodoEnvironmentKey
        );

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

    private void ClockodoEinstellungenAnzeigen()
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

    private static void LinkInBrowserÖffnen(string link)
    {
        Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
    }

    private void lnkClockodo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        LinkInBrowserÖffnen(((Control)sender).Text);
    }

    internal delegate void EinstellungenGeladenEventHandler(
        object sender,
        EinstellungenGeladenEventArgs e
    );
}
