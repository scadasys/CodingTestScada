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
        /// Ellenőrzi, hogy elérhető-e egy újabb verzió a programból.
        /// </summary>
        /// <returns>Igaz, ha elérhető frissítés, különben hamis.</returns>
        public static bool CheckForUpdate()
        {
            return false;
        }

        /// <summary>
        /// Visszaadja a legmagasabb verziószámú program fájljának az elérési útját
        /// a "ProgramVersions/" mappában. Az elérési út legyen relatív az updaterhez.
        /// Ha a "ProgramVersions/" mappa üres, akkor térjen vissza egy üres karakterlánccal.
        /// </summary>
        /// <returns>A legújabb verzió fájljának elérési útja.</returns>
        public static string GetLatestVersionPath()
        {
            return "";
        }

        /// <summary>
        /// Lekéri egy futtatható fájl verziószámát.
        /// </summary>
        /// <param name="exePath">A futtatható fájl elérési útja.</param>
        /// <returns>A fájl verziószáma szövegként.</returns>
        public static string GetExeVersion(string exePath)
        {
            return "0.0.0.0";
        }

        /// <summary>
        /// Megkérdezi a felhasználót, hogy azonnal frissíteni szeretné-e a programot, vagy későbbre halasztja.
        /// [Y] Frissítés most - igaz értéket ad vissza.
        /// [N] Frissítés később - hamis értéket ad vissza.
        /// </summary>
        /// <returns>Igaz, ha a felhasználó a frissítés mellett dönt, különben hamis.</returns>
        private static bool PromptUserForUpdate()
        {
            return false;
        }

        static void Main()
        {
            Console.WriteLine("Az alkalmazás indítása...");

            if (CheckForUpdate())
            {
                bool updateNow = PromptUserForUpdate();

                if (updateNow)
                {
                    Console.WriteLine("A program frissült.");
                }
                else
                {
                    Console.WriteLine("A frissítés elhalasztva. A következő indításkor újra ellenőrzésre kerül.");
                }
            }
            else
            {
                Console.WriteLine("Nem található frissítés.");
            }

            Console.ReadLine();
        }
    }
}
