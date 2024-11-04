using System.Diagnostics;

namespace Spotify_Premium_Installer.Installation
{
    internal static class Uninstaller
    {
        internal static async Task UninstallSpotifyAsync()
        {
            using (Process process = new Process { StartInfo = GetProcessStartInfo(GetUninstallSpotifyScriptLocation()) })
            {
                process.Start();
                await process.WaitForExitAsync();
            }
        }

        internal static async Task UninstallSpotifyPatchesAsync()
        {
            using (Process process = new Process { StartInfo = GetProcessStartInfo(GetUninstallSpotifyPatchesScriptLocation()) })
            {
                process.Start();
                await process.WaitForExitAsync();
            }
        }

        private static ProcessStartInfo GetProcessStartInfo(string fileName)
        {
            return new ProcessStartInfo
            {
                FileName = fileName,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
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