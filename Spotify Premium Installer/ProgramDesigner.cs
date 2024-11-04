namespace Spotify_Premium_Installer
{
    internal partial class Program
    {
        internal static void PrepareConsole()
        {
            SetTitle("Spotify Premium Installer");
            SetColours(ConsoleColor.White, Console.BackgroundColor);
        }

        internal static void SetTitle(string title) => Console.Title = title;

        internal static void SetColours(ConsoleColor foregroundColour, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColor;
        }
    }
}