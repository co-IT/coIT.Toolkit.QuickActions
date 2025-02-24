using System.Diagnostics;

namespace coIT.Toolkit.QuickActions;

internal static class Program
{
  /// <summary>
  ///   The main entry point for the application.
  /// </summary>
  [STAThread]
  private static void Main()
  {
    var updatesWurdenGefundenUndWerdenDurchgeführt = UpdaterAktualisiertAnwendung();

    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    if (updatesWurdenGefundenUndWerdenDurchgeführt)
      return;

    ApplicationConfiguration.Initialize();
    Application.Run(new FormMain());
  }

  private static bool UpdaterAktualisiertAnwendung()
  {
    var updaterPfad = ErwarteterPfadFürUpdater();

    if (!File.Exists(updaterPfad))
      return false;

    var process = Process.Start(updaterPfad);
    process.WaitForExit();
    var code = process.ExitCode;
    process.Close();

    // Updater exit code 0 bedeutet, dass Updates gefunden wurden
    // https://www.advancedinstaller.com/user-guide/updater.html#section370
    var updateGefundenExitCode = 0;

    return code == updateGefundenExitCode;
  }

  private static string ErwarteterPfadFürUpdater()
  {
#if DEBUG
    var appdataOrdner = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    return Path.Combine(appdataOrdner, "co-IT.eu GmbH", "coIT.Toolkit.QuickActions", "updater.exe");
#else
    return Path.Combine(Application.StartupPath, "..", "updater.exe");
#endif
  }
}
