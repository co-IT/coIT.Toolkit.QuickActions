using Azure;
using Azure.Data.Tables;

namespace coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;

internal class LexofficeKonfigurationEntity : ITableEntity
{
  internal static readonly string TabellenName = "LexofficeKonfiguration";

  // Globale Konfiguration für alle Nutzer
  internal static readonly string GlobalIdentifier = "global";

  public string LexofficeKey { get; set; }

  public string PartitionKey
  {
    get => TabellenName;
    set { }
  }

  public string RowKey
  {
    get => GlobalIdentifier;
    set { }
  }

  public DateTimeOffset? Timestamp { get; set; }
  public ETag ETag { get; set; }
}
