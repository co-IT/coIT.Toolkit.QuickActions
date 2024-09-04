using Azure;
using coIT.Libraries.Clockodo.TimeEntries.Contracts;
using coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter;
using Team = coIT.Libraries.Toolkit.Datengrundlagen.Mitarbeiter.Team;

namespace coIT.Toolkit.QuickActions;

internal class MitarbeiterMergen
{
  public static List<Mitarbeiter> ClockodoMitarbeiterHinzufügen(
    List<UserWithTeam> clockodoBenutzer,
    List<Mitarbeiter> mitarbeiter
  )
  {
    var adminNutzerId = 350599;
    var clockodoMitarbeiter = clockodoBenutzer.Where(user => user.Id != adminNutzerId).Select(ZuMitarbeiter).ToList();

    var liste = new List<Mitarbeiter>();
    liste.AddRange(mitarbeiter);
    liste.AddRange(clockodoMitarbeiter);

    return liste;
  }

  private static Mitarbeiter ZuMitarbeiter(UserWithTeam clockodoBenutzer)
  {
    var name = clockodoBenutzer.Name.Split(":")[1].Trim();
    var nummer = clockodoBenutzer.Name.Split(":")[0].Trim();

    return new Mitarbeiter(
      int.Parse(nummer),
      name,
      clockodoBenutzer.Active,
      new Team { Id = clockodoBenutzer.Id, Name = clockodoBenutzer.Name },
      null,
      new ETag()
    );
  }
}
