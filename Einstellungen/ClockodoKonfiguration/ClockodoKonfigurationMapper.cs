using coIT.Libraries.Clockodo.Absences;
using coIT.Libraries.ConfigurationManager.Cryptography;
using CSharpFunctionalExtensions;

namespace coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration
{
    internal class ClockodoKonfigurationMapper
    {
        private readonly IDoCryptography _cryptographyService;

        public ClockodoKonfigurationMapper(IDoCryptography cryptographyService)
        {
            _cryptographyService = cryptographyService;
        }

        public Result<ClockodoEinstellungen> VonEntity(ClockodoKonfigurationEntity entity)
        {
            return _cryptographyService
                .Decrypt(entity.ApiToken)
                .Map(apiToken => new ClockodoEinstellungen
                {
                    ApiToken = apiToken,
                    EmailAddress = entity.EmailAddress,
                });
        }
    }
}
