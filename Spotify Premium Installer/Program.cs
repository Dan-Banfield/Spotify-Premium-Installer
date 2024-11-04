using Spotify_Premium_Installer.Installation;

namespace Spotify_Premium_Installer
{
    internal partial class Program
    {
        static async Task Main()
        {
            PrepareConsole();
            await BeginProcess();

            Console.ReadKey();
        }

        internal static async Task BeginProcess()
        {
            switch (CurrentInstallation())
            {
                case true:
                    Console.WriteLine("\nUninstalling... Please wait.\n");
                    await Uninstaller.UninstallSpotifyPatchesAsync();
                    await Uninstaller.UninstallSpotifyAsync();
                    break;
            }
            Console.WriteLine("\nInstalling... Please wait.\n");
            Installer.InstallSpotifyPremium();
        }

        internal static bool CurrentInstallation()
        {
            string response = ConsoleUtilities.AskQuestion("Do you currently have Spotify installed? (yes/no): ");

            return (response == "yes" || response == "y" || response == "yeah");
        }
    }
}