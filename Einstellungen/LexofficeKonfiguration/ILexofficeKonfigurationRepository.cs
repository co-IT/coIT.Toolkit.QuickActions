using CSharpFunctionalExtensions;

namespace coIT.Toolkit.QuickActions.Einstellungen.LexofficeKonfiguration;

public interface ILexofficeKonfigurationRepository
{
  public Task<Result<LexofficeEinstellungen>> Get(CancellationToken cancellationToken = default);
}
