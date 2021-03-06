namespace BashSoft
{
    using System;

    public static class InputReader
    {
        private const string EndCommand = "quit";

        public static void StartReadingCommands()
        {
            StudentsRepository.InitializeData("dataNew.txt");
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}>");
            string input = Console.ReadLine();
            input = input.Trim();
            while (input != EndCommand)
            {
                CommandInterpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}>");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}
