using coIT.Libraries.Clockodo.TimeEntries;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;
using CSharpFunctionalExtensions;

namespace coIT.Toolkit.QuickActions.Lexoffice.RechnungspositionenGenerator
{
    public partial class LexofficeRechnungspositionsGenerator : UserControl
    {
        private readonly ClockodoEinstellungen _clockodoEinstellungen;
        private readonly IMitarbeiterRepository _mitarbeiterRepository;
        private List<Mitarbeiter> _mitarbeiterListe = new();

        public LexofficeRechnungspositionsGenerator(
            ClockodoEinstellungen clockodoEinstellungen,
            IMitarbeiterRepository mitarbeiterRepository
        )
        {
            InitializeComponent();
            _clockodoEinstellungen = clockodoEinstellungen;
            _mitarbeiterRepository = mitarbeiterRepository;
        }

        private async void LexofficeRechnungspositionsGenerator_Load(object sender, EventArgs e)
        {
            btnPositionErstellen.Enabled = false;

            lbxKunde.Items.Clear();
            lbxKunde.Items.AddRange(CustomerPositions.All);

            lbxLeistung.Items.Clear();
            lbxLeistung.Items.AddRange(ServiceTypePositions.All);

            await MitarbeiterListeLaden();

            btnPositionErstellen.Enabled = true;
        }

        private async Task MitarbeiterListeLaden()
        {
            var mitarbeiterErgebnis = await Result
                .Success()
                .Map(() => new TimeEntriesService(_clockodoEinstellungen.ClockodoCredentials))
                .Map((clockodoService) => clockodoService.GetAllUsers())
                .Map((clockodoMitarbeiter) => clockodoMitarbeiter.ToList())
                .BindZip((_) => _mitarbeiterRepository.GetAll())
                .Map(tuple =>
                    MitarbeiterMergen.ClockodoMitarbeiterHinzufügen(
                        tuple.First,
                        tuple.Second.ToList()
                    )
                );

            if (mitarbeiterErgebnis.IsSuccess)
            {
                lbxMitarbeiter.Items.Clear();
                var aktiveMitarbeiter = mitarbeiterErgebnis.Value.Where(mitarbeiter =>
                    mitarbeiter.Aktiv
                );
                _mitarbeiterListe = aktiveMitarbeiter.ToList();
                lbxMitarbeiter.Items.AddRange(_mitarbeiterListe.ToArray());
                return;
            }

            MessageBox.Show(
                "Die Liste an Mitarbeitern konnte nicht geladen werden. Bitte starte die Anwendung neu und überprüfe Konfigurationen und Internetverbindung",
                "Kritischer Fehler",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void btnPositionErstellen_Click(object sender, EventArgs e)
        {
            var rechnungsPositionErgebnis = KundeAuslesen()
                .BindZip((_) => LeistungAuslesen())
                .Bind(
                    (kundeUndLeistung) =>
                        KontoNummerErmitteln(kundeUndLeistung.First, kundeUndLeistung.Second)
                )
                .BindZip((_) => MitarbeiterAuslesen())
                .BindZip((_, _) => BeschreibungAuslesen())
                .Map(
                    ((int Konto, Mitarbeiter mitarbeiter, string beschreibung) zeilenwerte) =>
                        $"{zeilenwerte.Konto}-{zeilenwerte.mitarbeiter.Nummer}: {zeilenwerte.beschreibung}"
                );

            if (rechnungsPositionErgebnis.IsSuccess)
            {
                tbxErstelltePosition.Text = rechnungsPositionErgebnis.Value;
                return;
            }

            MessageBox.Show(
                rechnungsPositionErgebnis.Error,
                "Fehler bei der Erstellunge",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private Result<string> KundeAuslesen()
        {
            return Maybe
                .From(lbxKunde.SelectedItem)
                .ToResult("Bitte wähle zuerst einen Kunden aus")
                .Map(kundeAlsObject => (string)kundeAlsObject!);
        }

        private Result<string> LeistungAuslesen()
        {
            return Maybe
                .From(lbxLeistung.SelectedItem)
                .ToResult("Bitte wähle zuerst eine Leistung aus")
                .Map(leistungAlsObjekt => (string)leistungAlsObjekt!);
        }

        private Result<Mitarbeiter> MitarbeiterAuslesen()
        {
            var test = lbxLeistung.SelectedItem;

            return Maybe
                .From(lbxMitarbeiter.SelectedItem)
                .ToResult("Bitte wähle zuerst einen Mitarbeiter aus")
                .Map(mitarbeiterAlsObjekt => (Mitarbeiter)mitarbeiterAlsObjekt!);
        }

        private Result<string> BeschreibungAuslesen()
        {
            return Result
                .Success(tbxTitelDerPosition.Text)
                .Ensure(
                    titel => !string.IsNullOrWhiteSpace(titel),
                    "Bitte gebe einen Titel für diese Position an"
                );
        }

        private Result<int> KontoNummerErmitteln(string kunde, string leistung)
        {
            return (kunde, leistung) switch
            {
                (CustomerPositions.Heco, ServiceTypePositions.Service) => 8504,
                (CustomerPositions.Hecoform, ServiceTypePositions.Service) => 8504,
                (CustomerPositions.Varinox, ServiceTypePositions.Service) => 8337,
                (CustomerPositions.Varinox, ServiceTypePositions.GoodsSale) => 8504,
                (CustomerPositions.Heco, ServiceTypePositions.GoodsSale) => 8505,
                (CustomerPositions.Hecoform, ServiceTypePositions.GoodsSale) => 8505,
                (CustomerPositions.Heltec, ServiceTypePositions.GoodsSale) => 8506,
                (CustomerPositions.Heltec, ServiceTypePositions.Service) => 8500,
                (CustomerPositions.Other, ServiceTypePositions.Service) => 8500,
                (CustomerPositions.Other, ServiceTypePositions.GoodsSale) => 8506,
                _ => Result.Failure<int>(
                    "Konto konnte mit den eingegebenen Daten nicht ermittelt werden"
                ),
            };
        }

        private void lbxLeistung_SelectedValueChanged(object sender, EventArgs e)
        {
            var leistungLesenErgebnis = LeistungAuslesen();
            var mitarbeiter = _mitarbeiterListe;

            if (
                leistungLesenErgebnis.IsSuccess
                && leistungLesenErgebnis.Value == ServiceTypePositions.GoodsSale
            )
            {
                mitarbeiter = mitarbeiter.Where(m => m.Nummer > 99900).ToList();
            }

            lbxMitarbeiter.Items.Clear();
            lbxMitarbeiter.Items.AddRange(mitarbeiter.ToArray());
        }
    }
}
