using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;
using System.Reflection;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        /// <summary>
        /// Расположение сборки, которая содержит код, исполняемый в данный момент.
        /// </summary>
        private static readonly string LocalPath = Assembly.GetExecutingAssembly().Location;

        /// <summary>
        /// Информация о каталогах пути, по которому расположена сборка.
        /// </summary>
        private static readonly string DirectoryInformation = Path.GetDirectoryName(LocalPath) + @"\TestData";

        /// <summary>
        /// Задаёт путь к дефолтному файлу
        /// </summary>
        private static readonly string DefaultFilePath  = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\NoteApp\NoteApp.notes";

        private static readonly string ExpectedFileName = DirectoryInformation + @"\expectedProject.json";
        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            // Setup
            var expectedProject = new Project();
            expectedProject = ExpectedProject();
            var expectedFileContent = File.ReadAllText(ExpectedFileName);

            if (Directory.Exists(DirectoryInformation + @"\actualProject.json"))
            {
                Directory.Delete(DirectoryInformation + @"\actualProject.json", true);
            }

            // Act
            var actualFileName = DirectoryInformation + @"\actualProject.json";
            ProjectManager.SaveToFile(expectedProject, actualFileName);
            var actualFileContent = File.ReadAllText(actualFileName);

            // Assert
            Assert.IsTrue(Directory.Exists(DirectoryInformation));
            Assert.IsTrue(File.Exists(actualFileName));
            Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void LoadFromFile_CorrectProject_FileLoadedCorrectly()
        {
            // Setup
            var expectedProject = new Project();
            expectedProject = ExpectedProject();

            // Act
            var actualProject = ProjectManager.LoadFromFile(ExpectedFileName);

            // Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);
            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.Notes.Count; i++)
                {
                    Assert.AreEqual(expectedProject.Notes[i], actualProject.Notes[i]);
                }
            });
        }

        [Test]
        public void LoadFromFile_NonExistentFile_ReturnEmptyProject()
        {
            // Setup
            var nonExistentFileName = DirectoryInformation + @"\nonexist.notes";

            // Act
            var actualProject = ProjectManager.LoadFromFile(nonExistentFileName);

            // Assert
            Assert.IsNotNull(actualProject);
            Assert.AreEqual(actualProject.Notes.Count, 0);
        }
        [Test]
        public void LoadFromFile_UnCorrectFile_ReturnEmptyProject()
        {
            //Setup
            var testDataFolder = DirectoryInformation;
            var testFileName = testDataFolder + @"\UnCorrectFile.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.IsEmpty(actualProject.Notes);
        }

        public Project ExpectedProject()
        {
            var expectedProject = new Project();
            expectedProject.Notes.Add(new Note()
            {
                Name = "Note1",
                Text = "Text1",
                Category = NoteCategory.Other,
                CreatedTime = new DateTime(2022, 01, 19),
                ModifiedTime = new DateTime(2022, 01, 19)
            });
            return expectedProject;
        }
    }
}
