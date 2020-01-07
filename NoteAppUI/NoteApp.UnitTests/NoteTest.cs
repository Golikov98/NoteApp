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
    public class NoteTest
    {
        [Test(Description ="Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "День Рождения В.А. Борисова";
            var note = new Note();
            note.Name = expected;
            var actual = note.Name;

            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неправильного имени заметки более 50 символов")]
        public void TestNameSet_Longer50Simbols()
        {
            var wrongName = "1-2-3-4-5-6-7-8-9-0-1-2-3-4-5-6-7-8-9-0-1-2-3-4-5-6-7-8-9-0";
            var note = new Note();

            Assert.Throws<ArgumentException>(() => { note.Name = wrongName; },
                "Должно возникать исключение, если название заметки длиннее 50 символов");
        }

        [Test(Description = "Присвоение имени заметки 0 символов")]
        public void TestNameSet_Longer0Simbols()
        {
            var expected = string.Empty;
            var note = new Note();
            note.Name = expected;
            var defolt = "Без названия";
            var actual = note.Name;

            Assert.AreEqual(defolt, actual, "Cеттер Name возвращает неправильное имя заметки");
        }

        [Test(Description = "Позитивный тест геттера NoteCategory")]
        public void TestNoteCategoryGet_CorrectValue()
        {
            var expected = "Other";
            var note = new Note();
            note.NoteCategory = expected;
            var actual = note.NoteCategory;

            Assert.AreEqual(expected, actual, "Геттер NoteCategory возвращает неправильную категорию заметки");
        }

        [Test(Description = "Позитивный тест геттера NoteText")]
        public void TestNoteTextGet_CorrectValue()
        {
            var expected = "Проверка значения";
            var note = new Note();
            note.NoteText = expected;
            var actual = note.NoteText;

            Assert.AreEqual(expected, actual, "Геттер NoteText возвращает неправильный текст заметки");
        }

        [Test(Description = "Позитивный тест геттера CreationTime")]
        public void TestNoteCreationTimeGet_CorrectValue()
        {
            var expected = DateTime.Today;
            var note = new Note();
            note.CreationTime = expected;
            var actual = DateTime.Today;

            Assert.AreEqual(expected, actual, "Геттер CreationTime возвращает неправильную дату создания заметки");
        }

        [Test(Description = "Присвоение неправильной даты создания заметки")]
        public void TestCreationTimeSet_CorrectDate()
        {
            DateTime wrongCreationTime = DateTime.MaxValue;
            var note = new Note();

            Assert.Throws<ArgumentException>(() => { note.CreationTime = wrongCreationTime; },
                "Должно возникать исключение, если дата создания заметки больше чем DateTime.Now");
        }

        [Test(Description = "Позитивный тест геттера ModifiedTime")]
        public void TestNoteModifiedTime_CorrectValue()
        {
            var expected = DateTime.Today;
            var note = new Note();
            note.ModifiedTime = expected;
            var actual = DateTime.Today;

            Assert.AreEqual(expected, actual, "Геттер ModifiedTime возвращает неправильную дату редактирования заметки");
        }

        [Test(Description ="Присвоение неверной даты редактирования заметки")]
        public void TestModifiedTime_CorrectDate()
        {
            DateTime wrongModifiedTime = DateTime.MinValue;
            DateTime creationTime = DateTime.Today;
            var note = new Note();

            Assert.Throws<ArgumentException>(() => { note.CreationTime = creationTime; note.ModifiedTime = wrongModifiedTime; },
                "Должно возникать исключение, если дата редактирования заметки меньше, чем дата создания заметки");
        }
    }
}
