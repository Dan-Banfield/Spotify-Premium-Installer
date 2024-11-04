namespace Spotify_Premium_Installer.Installation
{
    internal static class Uninstaller
    {
        internal static void UninstallSpotify()
        {
            
        }

        internal static void UninstallSpotifyPatches()
        {

        }

        private static string GetUninstallSpotifyScriptLocation()
        {
            return Path.Combine
            (
                 AppContext.BaseDirectory,
                 "res",
                 "uninstallspotify.bat"
            );
        }

        private static string GetUninstallSpotifyPatchesScriptLocation()
        {
            return Path.Combine
            (
                 AppContext.BaseDirectory,
                 "res",
                 "uninstallpatch.bat"
            );
        }
    }
}