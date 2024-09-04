using CSharpFunctionalExtensions;

namespace coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration
{
    public interface IClockodoKonfigurationRepository
    {
        public Task<Result<ClockodoEinstellungen>> Get(
            CancellationToken cancellationToken = default
        );
    }
}
