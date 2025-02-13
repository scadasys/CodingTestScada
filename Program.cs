using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace CodingTestScada
{
    public class Updater
    {
        public static string mainAppPath = "Main/program.exe";
        public static string versionsFolder = "ProgramVersions/";

        /// <summary>
        /// Checks if a newer version of the application is available.
        /// </summary>
        /// <returns>True if an update is available, otherwise false.</returns>
        public static bool CheckForUpdate()
        {
            return false;
        }

        /// <summary>
        /// Retrieves the path of a program with the highest version number 
        /// in 'ProgramVersions/'. The path should be relative from this updater.
        /// If the 'ProgramVersions/' folder is empty, return an empty string
        /// </summary>
        /// <returns>Path to the newest version file.</returns>
        public static string GetLatestVersionPath()
        {
            return "";
        }

        /// <summary>
        /// Retrieves the version number of an executable file.
        /// </summary>
        /// <param name="exePath">Path to the exe file</param>
        /// <returns>Version string</returns>
        public static string GetExeVersion(string exePath)
        {
            return "0.0.0.0";
        }

        /// <summary>
        /// Prompts the user if they want to update now or delay the update.
        /// [Y] Update Now - returns true
        /// [N] Update Later - returns false
        /// </summary>
        /// <returns>True if the user agrees to update, otherwise false.</returns>
        private static bool PromptUserForUpdate()
        {
            // TODO: Implement logic to ask the user whether to update or delay
            return false;
        }


        static void Main()
        {
            Console.WriteLine("Starting application...");
            
            if (CheckForUpdate())
            {
                bool updateNow = PromptUserForUpdate();
                
                if (updateNow)
                {
                    Console.WriteLine("Updated program.");
                }
                else
                {
                    Console.WriteLine("Update delayed. It will be checked again on the next launch.");
                }
            }
            else
            {
                Console.WriteLine("No updates found.");
            }

            Console.ReadLine();
        }
    }
}