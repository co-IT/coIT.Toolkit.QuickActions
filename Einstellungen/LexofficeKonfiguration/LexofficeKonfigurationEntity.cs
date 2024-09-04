using Azure;
using Azure.Data.Tables;

namespace coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration
{
    internal class LexofficeKonfigurationEntity : ITableEntity
    {
        internal static readonly string TabellenName = "LexofficeKonfiguration";

        // Globale Konfiguration für alle Nutzer
        internal static readonly string GlobalIdentifier = "global";

        public string PartitionKey
        {
            get { return TabellenName; }
            set { return; }
        }
        public string RowKey
        {
            get { return GlobalIdentifier; }
            set { return; }
        }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }

        public string LexofficeKey { get; set; }
    }
}
