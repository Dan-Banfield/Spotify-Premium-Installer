namespace Spotify_Premium_Installer
{
    internal partial class Program
    {
        internal static void PrepareConsole()
        {
            SetTitle("Spotify Premium Installer");
            SetColours(ConsoleColor.White, Console.BackgroundColor);
            DisplayBubbleText();
        }

        internal static void SetTitle(string title) => Console.Title = title;

        internal static void SetColours(ConsoleColor foregroundColour, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColor;
        }

        internal static void DisplayBubbleText()
        {
            SetColours(ConsoleColor.Green, Console.BackgroundColor);
            Console.WriteLine(@"
 __          __  _                          _ 
 \ \        / / | |                        | |
  \ \  /\  / /__| | ___ ___  _ __ ___   ___| |
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ |
    \  /\  /  __/ | (_| (_) | | | | | |  __/_|
     \/  \/ \___|_|\___\___/|_| |_| |_|\___(_)
                                              
                                              
");
            SetColours(ConsoleColor.White, Console.BackgroundColor);
        }
    }
}