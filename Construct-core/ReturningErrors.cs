using System;
using System.Collections.Generic;

namespace Examples.Constructcore
{
    static class ReturningErrors
    {
        // Note we are now returning an int, rather than void.
        public static int Main(IEnumerable<string> args)
        {
            // Display a message and wait for Enter key to be pressed
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello world!");
            Console.WriteLine();

            // Process any incoming args using foreach
            // foreach (string arg in args)
            // Console.WriteLine("Arg: {0}", arg);
            //
            // Get arguments using System.Environment
            // string[] theArgs = Environment.GetCommandLineArgs();
            // foreach (string arg in theArgs)
            // Console.WriteLine("Arg: {0}", arg);

            // Helper method within the Program class
            ShowEnvironmentDetails();

            Console.ReadLine();

            // Arbituary error code
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            // Print out the rivers on this machine,
            // and other interesting details.

            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}
