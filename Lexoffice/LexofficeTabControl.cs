using coIT.Libraries.Toolkit.Datengrundlagen.KundenRelation;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using coIT.Libraries.Toolkit.Datengrundlagen.Umsatzkonten;
using coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;
using coIT.Toolkit.QuickActions.Lexoffice.RechnungspositionenGenerator;

namespace coIT.Toolkit.QuickActions.Lexoffice;

public partial class LexofficeTabControl : UserControl
{
  private readonly ClockodoEinstellungen _clockodoEinstellungen;
  private readonly IKontoRepository _kontoRepository;
  private readonly IKundeRepository _kundeRepository;
  private readonly LexofficeEinstellungen _lexofficeKonfiguration;
  private readonly IMitarbeiterRepository _mitarbeiterRepository;

  public LexofficeTabControl(
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

  private void LexofficeTabControl_Load(object sender, EventArgs e)
  {
    var rechnungsKontrolle = new LexofficeRechnungskontrolle(
      _lexofficeKonfiguration,
      _clockodoEinstellungen,
      _mitarbeiterRepository,
      _kundeRepository,
      _kontoRepository
    );

    tbpRechnungSelbstkontrolle.Controls.Add(rechnungsKontrolle);
    rechnungsKontrolle.Dock = DockStyle.Fill;

    var positionsGenerator = new LexofficeRechnungspositionsGenerator(_clockodoEinstellungen, _mitarbeiterRepository);

    tbpPositionsGenerator.Controls.Add(positionsGenerator);
    positionsGenerator.Dock = DockStyle.Fill;
  }
}
