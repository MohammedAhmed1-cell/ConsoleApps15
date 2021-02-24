using System;

namespace ConsoleAppProject.App05
{
    /// <summary>
    /// This class has a set of method that will draw out
    /// some useful game images using textual characters
    /// for Rock-Paper-Scissors game
    /// </summary>
    /// <author>
    /// Unkown ??
    /// </author>
    public static class GameImages
    {
        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void DrawScissors()
        {
               
            Console.Write("     \\            /");
            Console.WriteLine();
            Console.Write("      \\          /");
            Console.WriteLine();
            Console.Write("       \\        /");
            Console.WriteLine();
            Console.Write("        \\      /");
            Console.WriteLine();
            Console.Write("         \\    /");
            Console.WriteLine();
            Console.Write("          \\  /");
            Console.WriteLine();
            Console.Write("           **");
            Console.WriteLine();
            Console.Write("          /  \\");
            Console.WriteLine();
            Console.Write("    (----/    \\----)");
            Console.WriteLine();
            Console.Write("     \\  /      \\  /");
            Console.WriteLine();
            Console.Write("      ==        ==");
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void DrawRock()
        {
            
            Console.WriteLine("                 ___---___     ");
            
            Console.WriteLine("              .--         --.    ");
            
            Console.WriteLine("           ./   ()       .-. \\.   ");
            
            Console.WriteLine("           /   o    .   (   )  \\  ");
            
            Console.WriteLine("          / .            '-'    \\  ");
            
            Console.WriteLine("         /     ()   ()           \\ ");
            
            Console.WriteLine("        |    o           ()       | ");
            
            Console.WriteLine("        |      .--.           O   | ");
            
            Console.WriteLine("         \\ .  |    |              |  ");
            
            Console.WriteLine("          \\   `.__.'     o   .   /    ");
            
            Console.WriteLine("           `\\  o    ()         /'    ");
            
            Console.WriteLine("              `--___    ___--'    ");
            
            Console.WriteLine("                     ---         ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void DrawPaper()
        {
            
            Console.WriteLine("      .--.------------------.");
            
            Console.WriteLine("     /      \\  \\ \\ \\ \\ \\ \\ \\ \\");
           
            Console.WriteLine("    /   OOO  \\                |");
            
            Console.WriteLine("   |   OOOO   || A N D R E X | |");
            
            Console.WriteLine("   |   OOOO   |                |");
            
            Console.WriteLine("    \\   OOO   /                /");
            
            Console.WriteLine("     \\      // / / / / / / / //");
           
            Console.WriteLine("       `--'-|| | | | | | | | |");
            
            Console.WriteLine("             \\                \\");
            
            Console.WriteLine("              \\                \\");
            
            Console.WriteLine("               \\                \\");
            
            Console.WriteLine("                \\ \\ \\ \\ \\ \\ \\ \\ \\\\");
            
            Console.WriteLine("                 \\________________\\");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// This will draw a smile
        /// *******************************************************
        /// </summary>
        public static void DrawSmile()
        {
            Console.WriteLine("\n                    .-\"\"\"\"-.-\"\"\"\"-. ");
            Console.WriteLine("               _.'`               `'._   ");
            Console.WriteLine("            .-'  __..,.___.___.,..__  '-.   ");
            Console.WriteLine("           '-.-;` |  |    |    |  | `;-.-'   ");
            Console.WriteLine("            \\'-\\_/\\__|    |    |__/\\_/-'/   ");
            Console.WriteLine("             \\, _     '---'---'     _ ,/   ");
            Console.WriteLine("              \\'./`'.--.--.--,--.'`\\.'/   ");
            Console.WriteLine("               \\ `'-;__|__|__|__;-'` /   ");
            Console.WriteLine("                '.                 .'   ");
            Console.WriteLine("                 `'-....---....-'`    ");
        }

        /// <summary>
        /// *******************************************************
        /// This will draw an image of ThumbsUp on the console
        /// *******************************************************
        /// </summary>
        public static void DrawThumbsUp()
        {
            Console.WriteLine();
            Console.WriteLine("       _ ");
            Console.WriteLine("      ( ((  ");
            Console.WriteLine("       \\ =\\   ");
            Console.WriteLine("      __\\_ `-\\   ");
            Console.WriteLine("     (____))(  \\-----  ");
            Console.WriteLine("     (____)) _    ");
            Console.WriteLine("     (____))   ");
            Console.WriteLine("     (____))____/-----  ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// This will draw an image of ThumbsDown on the console
        /// *******************************************************
        /// </summary>
        public static void DrawThumbsDown()
        {
            Console.WriteLine();
            Console.WriteLine("       ______ ");
            Console.WriteLine("     ((____  \\-----  ");
            Console.WriteLine("     ((_____         ");
            Console.WriteLine("     ((_____      ");
            Console.WriteLine("     ((____   -----   ");
            Console.WriteLine("          /  /    ");
            Console.WriteLine("         (_((     ");
            Console.WriteLine();
        }
    }
}
