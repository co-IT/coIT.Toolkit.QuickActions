using coIT.Clockodo.QuickActions.Lexoffice.RechnungspositionenGenerator;
using coIT.Libraries.Clockodo.TimeEntries;
using coIT.Libraries.ConfigurationManager;
using coIT.Libraries.LexOffice;
using coIT.Libraries.Toolkit.Datengrundlagen.KundenRelation;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using coIT.Libraries.Toolkit.Datengrundlagen.Umsatzkonten;

namespace coIT.Clockodo.QuickActions.Lexoffice
{
    public partial class LexofficeTabControl : UserControl
    {
        private readonly FileSystemManager _fileSystemManager;
        private readonly EnvironmentManager _environmentManager;
        private readonly IMitarbeiterRepository _mitarbeiterRepository;
        private readonly IKundeRepository _kundeRepository;
        private readonly IKontoRepository _kontoRepository;

        public LexofficeTabControl(
            EnvironmentManager environmentManager,
            IMitarbeiterRepository mitarbeiterRepository,
            IKundeRepository kundeRepository,
            IKontoRepository kontoRepository
        )
        {
            InitializeComponent();
            _environmentManager = environmentManager;
            _mitarbeiterRepository = mitarbeiterRepository;
            _kundeRepository = kundeRepository;
            _kontoRepository = kontoRepository;
        }

        private void LexofficeTabControl_Load(object sender, EventArgs e)
        {
            var rechnungsKontrolle = new LexofficeRechnungskontrolle(
                _environmentManager,
                _mitarbeiterRepository,
                _kundeRepository,
                _kontoRepository
            );

            tbpRechnungSelbstkontrolle.Controls.Add(rechnungsKontrolle);
            rechnungsKontrolle.Dock = DockStyle.Fill;

            var positionsGenerator = new LexofficeRechnungspositionsGenerator(
                _environmentManager,
                _mitarbeiterRepository
            );

            tbpPositionsGenerator.Controls.Add(positionsGenerator);
            positionsGenerator.Dock = DockStyle.Fill;
        }
    }
}
