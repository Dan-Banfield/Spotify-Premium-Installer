namespace Spotify_Premium_Installer
{
    internal static class ConsoleUtilities
    {
        internal static string AskQuestion(string question)
        {
            Program.SetColours(ConsoleColor.White, Console.BackgroundColor); Console.Write("["); Program.SetColours(ConsoleColor.Cyan, Console.BackgroundColor); Console.Write("QUESTION"); Program.SetColours(ConsoleColor.White, Console.BackgroundColor); Console.Write("] ");
            Console.Write(question);

            return Console.ReadLine();
        }
    }
}