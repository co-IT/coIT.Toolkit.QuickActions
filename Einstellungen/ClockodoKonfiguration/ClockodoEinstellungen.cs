using coIT.Libraries.Clockodo;
using coIT.Libraries.Clockodo.TimeEntries.Contracts;

namespace coIT.Toolkit.QuickActions.Einstellungen.ClockodoKonfiguration;

public record ClockodoEinstellungen
{
    public required string ApiToken { get; init; }
    public required string EmailAddress { get; init; }

    public TimeEntriesServiceSettings ClockodoCredentials =>
        new(EmailAddress, ApiToken, "co-IT Clockodo Quick Actions", "info@co-it.eu");

    public ApiConnectionSettings CreateApiConnectionSettings =>
        new ApiConnectionSettings(
            EmailAddress,
            ApiToken,
            "co-IT Clockodo Quick Actions",
            "info@co-it.eu",
            new Uri("https://my.clockodo.com/")
        );
}
