
using NUnit.Framework;
using System;
using System.IO;
using System.Diagnostics;

namespace CodingTestScada
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void GetExeVersion_Returns_Correct_Version()
        {
            string expectedVersion = "1.0.0.0";
            string actualVersion = Updater.GetExeVersion("Versions/program_1.0.0.0.exe");

            Assert.That(actualVersion, Is.EqualTo(expectedVersion));
        }
        [Test]
        public void GetExeVersion_Returns_Correct_Version_Unknown()
        {
            string expectedVersion = "0.9.0.0";
            string actualVersion = Updater.GetExeVersion("Versions/program_unknown.exe");

            Assert.That(actualVersion, Is.EqualTo(expectedVersion));
        }

        [Test]
        public void CheckForUpdate_Returns_True_When_New_Version_Available()
        {
            bool result = Updater.CheckForUpdate();
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetLatestVersionPath_Returns_The_Correct_Newest_Path()
        {
            string result = Updater.GetLatestVersionPath();
            Assert.That(result, Is.EqualTo("Versions/program_1.1.0.0.exe"));
        }

        [Test]
        public void CheckForUpdate_Empty_Versions_Folder_Case()
        {
            if (Directory.Exists(Updater.versionsFolder))
            {
                Directory.Delete(Updater.versionsFolder, true);
            }
            Directory.CreateDirectory(Updater.versionsFolder);

            string result = Updater.GetLatestVersionPath();
            Assert.That(result, Is.EqualTo(""));

            if (!Directory.Exists(Updater.versionsFolder))
            {
                Directory.CreateDirectory(Updater.versionsFolder);
            }

            foreach (string file in Directory.GetFiles("data"))
            {
                string destFile = Path.Combine(Updater.versionsFolder, Path.GetFileName(file));
                File.Copy(Directory.GetCurrentDirectory()+  "/" + file, Directory.GetCurrentDirectory() + "/" + destFile, true);
            }
        }
    }
}