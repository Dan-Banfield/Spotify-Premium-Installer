using Spotify_Premium_Installer.Installation;

namespace Spotify_Premium_Installer
{
    internal partial class Program
    {
        static void Main()
        {
            PrepareConsole();
            BeginProcess();

            Console.ReadKey();
        }

        internal static void BeginProcess()
        {
            switch (CurrentInstallation())
            {
                case true:
                    Uninstaller.UninstallSpotify();
                    break;
            }
            Installer.InstallSpotifyPremium();
        }

        internal static bool CurrentInstallation()
        {
            string response = ConsoleUtilities.AskQuestion("Do you currently have Spotify installed? (yes/no): ");

            return (response == "yes" || response == "y" || response == "yeah");
        }
    }
}