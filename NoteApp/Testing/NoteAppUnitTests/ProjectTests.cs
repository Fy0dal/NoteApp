using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    
    [TestFixture]
    public class ProjectTests
    {      
        [Test]
        public void Name_CorrectName_ReturnsSameName()
        {
            // Setup
            var project = new Project();
            var expected = new List<Note>();
            expected.Add(new Note("Name1", "Text1", NoteCategory.Other));

            // Act
            project = new Project();
            project.Notes.Add(new Note("Name1", "Text1", NoteCategory.Other));
            var actual = project.Notes;

            // Assert
            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[0].Text, actual[0].Text);
            Assert.AreEqual(expected[0].Category, actual[0].Category);
        }
    }
}
