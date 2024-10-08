using System.Collections.Immutable;
using System.Text.RegularExpressions;
using coIT.Libraries.Clockodo.TimeEntries;
using coIT.Libraries.Clockodo.TimeEntries.Contracts;
using coIT.Libraries.LexOffice;
using coIT.Libraries.Lexoffice.BusinessRules;
using coIT.Libraries.Lexoffice.BusinessRules.Rechnung;
using coIT.Libraries.LexOffice.DataContracts.Invoice;
using coIT.Libraries.Toolkit.Datengrundlagen.KundenRelation;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using coIT.Libraries.Toolkit.Datengrundlagen.Umsatzkonten;
using coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;
using CSharpFunctionalExtensions;

namespace coIT.Toolkit.QuickActions.Lexoffice;

public partial class LexofficeRechnungskontrolle : UserControl
{
  private readonly ClockodoEinstellungen _clockodoEinstellungen;
  private readonly IKontoRepository _kontoRepository;
  private readonly IKundeRepository _kundeRepository;
  private readonly LexofficeEinstellungen _lexofficeKonfiguration;
  private readonly IMitarbeiterRepository _mitarbeiterRepository;

  public LexofficeRechnungskontrolle(
    LexofficeEinstellungen lexofficeKonfiguration,
    ClockodoEinstellungen clockodoEinstellungen,
    IMitarbeiterRepository mitarbeiterRepository,
    IKundeRepository kundeRepository,
    IKontoRepository kontoRepository
  )
  {
    InitializeComponent();
    _lexofficeKonfiguration = lexofficeKonfiguration;
    _clockodoEinstellungen = clockodoEinstellungen;
    _mitarbeiterRepository = mitarbeiterRepository;
    _kundeRepository = kundeRepository;
    _kontoRepository = kontoRepository;
  }

  private async void btnRechnungPrüfen_Click(object sender, EventArgs e)
  {
    EingabeBlockieren(false);

    var rechnungPrüfungsErgebnis = await Result
      .Success(tbxRechnungUrl.Text)
      .Bind(RechnungsIdAuslesen)
      .Bind(RechnungsdatenVonLexofficeAbfragen)
      .BindZip(_ => RechnungsprüferErstellen())
      .Bind(tuple => RechnungÜberprüfen(tuple.First, tuple.Second));

    PrüfergebnisAnzeigen(rechnungPrüfungsErgebnis);

    EingabeBlockieren(true);
  }

  private void EingabeBlockieren(bool blockieren)
  {
    btnRechnungPrüfen.Enabled = blockieren;
    tbxRechnungUrl.Enabled = blockieren;
  }

  private void PrüfergebnisAnzeigen(Result rechnungPrüfungsErgebnis)
  {
    if (rechnungPrüfungsErgebnis.IsFailure)
    {
      lblErgebnisse.Text = rechnungPrüfungsErgebnis.Error.Replace(", ", $"{Environment.NewLine}");
      return;
    }

    MessageBox.Show(
      "Es konnten keine Fehler in dieser Rechnung gefunden werden",
      "Gratulation",
      MessageBoxButtons.OK,
      MessageBoxIcon.None
    );
    lblErgebnisse.Text = "Es wurden keine Fehler in dieser Rechnung gefunden";
  }

  private async Task<Result<Invoice>> RechnungsdatenVonLexofficeAbfragen(string rechnungsId)
  {
    return await Result
      .Success()
      .Map(() => new LexofficeService(_lexofficeKonfiguration.LexofficeKey))
      .MapTry(
        lexofficeService => lexofficeService.GetInvoiceAsync(rechnungsId),
        _ =>
          $"Hast du den richtigen Rechnungslink kopiert? Die Rechnung mit der ID {rechnungsId} konnte nicht gefunden werden."
      )
      .Ensure(
        invoice => invoice is not null,
        "Beim Abrufen der Rechnung gab es einen Fehler. Bitte überprüfe die URL und versuche es erneut."
      );
  }

  private async Task<Result> RechnungÜberprüfen(Invoice rechnung, IchPrüfe<Invoice> prüfer)
  {
    return prüfer.Prüfen(rechnung);
  }

  private async Task<Result<AlleRechnungsregeln>> RechnungsprüferErstellen()
  {
    return await LeistungsempfängerLaden()
      .BindZip(_ => BekannteKontenLaden())
      .BindZip((_, _) => AlleMitarbeiterLaden())
      .Map(tuple => new AlleRechnungsregeln(tuple.First, tuple.Second, tuple.Third));
  }

  private async Task<Result<ImmutableList<Mitarbeiter>>> AlleMitarbeiterLaden()
  {
    return await _mitarbeiterRepository
      .GetAll()
      .BindZip(_ => MitarbeiterAusClockodoLaden())
      .Map(tuple =>
        MitarbeiterMergen.ClockodoMitarbeiterHinzufügen(tuple.Second, tuple.First.ToList()).ToImmutableList()
      );
  }

  private async Task<Result<List<UserWithTeam>>> MitarbeiterAusClockodoLaden()
  {
    return await Result
      .Success(_clockodoEinstellungen)
      .Map(konfiguration => new TimeEntriesService(konfiguration.ClockodoCredentials))
      .Map(clockodoService => clockodoService.GetAllUsers())
      .Map(mitarbeiter => mitarbeiter.ToList());
  }

  private async Task<Result<ImmutableList<Umsatzkonto>>> BekannteKontenLaden()
  {
    return await _kontoRepository.GetAll().Map(kontenliste => kontenliste.ToImmutableList());
  }

  private async Task<Result<ImmutableList<KundeRelation>>> LeistungsempfängerLaden()
  {
    return await _kundeRepository.GetAll().Map(kundenstamm => kundenstamm.ToImmutableList());
  }

  private Result<string> RechnungsIdAuslesen(string text)
  {
    var valideIdRegex = new Regex("[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$");

    var valideIdÜbereinstimmungen = valideIdRegex.Match(text);
    if (!valideIdÜbereinstimmungen.Success)
      return Result.Failure<string>(
        "Stell sicher, dass du die richtige URL eingefügt hast. Die angegebene URL konnte nicht erkannt werden."
      );

    var übereinstimmungen = valideIdRegex.Match(text);
    if (übereinstimmungen.Captures.Count > 1)
      return Result.Failure<string>(
        "Stell sicher, dass du die richtige URL eingefügt hast. In der angegebenen URL wurden mehrere IDs gefunden."
      );

    return übereinstimmungen.Value;
  }
}
