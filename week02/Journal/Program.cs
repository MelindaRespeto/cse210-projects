using System;

/// <summary>
/// Program exceeds requirements by:
/// 1. Allowing user to choose custom filenames for save/load.
/// 2. Adding total entry count display.
/// 3. Automatically records date.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        ProgramData programData = new ProgramData();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("=== Journal Menu ===");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    programData.AddEntry();
                    break;

                case "2":
                    programData.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter file name to save (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    programData.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter file name to load (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    programData.LoadFromFile(loadFile);
                    break;

                case "5":
                    isRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}
