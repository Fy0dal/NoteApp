using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        [Test]
        public void Name_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            var expected = "Name1";
            note.Name = expected;

            // Act
            var actual = note.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Name_WrongName_ThrowsException()
        {
            // Setup
            var note = new Note();
            string wrongName = "Жаль что не сможешь по порталам потаскать. Оставалось пару шмоток выбить для билда.((((((";

            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                note.Name = wrongName; 
            }, "Exception if Name of note more 50 symbol");
        }

        [Test]
        public void Name_CorrectName_SetCorrectName()
        {
            //Setup
            var note = new Note();
            string expected = "Name1";

            //Act
            note.Name = expected;
            string actual = note.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Name_EmptyName_SetCorrectName()
        {
            // Setup
            var note = new Note();
            var expected = "Name not writed";

            // Act
            note.Name = "";
            var actual = note.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void Category_CorrectCategory_ReturnsSameCategory()
        {
            // Setup
            var note = new Note();
            var expected = NoteCategory.Other;
            note.Category = expected;

            // Act
            var actual = note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_CorrectCategory_SetCorrectCategory()
        {
            //Setup
            var note = new Note();
            var expected = NoteCategory.Other;

            //Act
            note.Category = expected;
            var actual = note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Text_CorrectText_ReturnsSameText()
        {
            // Setup
            var note = new Note();
            var expected = "Text";
            note.Text = expected;
            // Act
            var actual = note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Text_CorrectText_SetsCorrectText()
        {
            //Setup
            var note = new Note();
            var expected = "Text1";

            //Act
            note.Text = expected;
            var actual = note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreatedTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();
            var expected = DateTime.Now;
            note.CreatedTime = expected;

            // Act
            var actual = note.CreatedTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreatedTime_CorrectValue_SetsCorrectValue()
        {
            // Setup
            var note = new Note();
            var expected = DateTime.Now;

            // Act
            note.CreatedTime = expected;
            var actual = note.CreatedTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModifiedTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = new Note();

            var expected = DateTime.Now;

            // Act
            note.ModifiedTime = expected;

            // Assert
            var actual = note.ModifiedTime;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModifiedTime_CorrectValue_SetsCorrectValue()
        {
            //Setup
            var note = new Note();

            var expected = DateTime.Now;

            //Act
            note.ModifiedTime = expected;
            var actual = note.ModifiedTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Clone_CorrectClone_ReturnSameValue()
        {
            // Setup
            var note = new Note();
            var expected = new Note("Name1","Text1",NoteCategory.People);

            // Act
            var actual = (Note)expected.Clone();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
