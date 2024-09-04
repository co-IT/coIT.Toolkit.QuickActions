using coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.DatabaseKonfiguration;
using coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;

namespace coIT.Toolkit.QuickActions.Einstellungen
{
    internal class EinstellungenGeladenEventArgs : EventArgs
    {
        public required ClockodoEinstellungen ClockodoEinstellungen { get; init; }
        public required DatabaseEinstellungen DatabaseEinstellungen { get; init; }
        public required LexofficeEinstellungen LexofficeEinstellungen { get; init; }
    }
}
