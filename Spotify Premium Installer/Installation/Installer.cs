using System.Runtime.InteropServices;

namespace Spotify_Premium_Installer.Installation
{
    internal static class Installer
    {
        [DllImport("msvcrt.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int system(string command);

        internal static void InstallSpotifyPremium()
        {
            string pathToScript = GetInstallSpotifyPremiumScriptLocation();
            string command = $"\"{pathToScript}\"";

            system(command);
        }

        private static string GetInstallSpotifyPremiumScriptLocation()
        {
            return Path.Combine
            (
                 AppContext.BaseDirectory,
                 "res",
                 "installspotifypremium.bat"
            );
        }
    }
}