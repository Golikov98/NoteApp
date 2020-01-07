using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    class ProjectManagerTest
    {
        [Test(Description ="Позитивный тест метода SaveToFile и метода LoadFromFile")]
        public void ProjectManagerSaveToFileTest()
        {
            Note noteTest = new Note();
            Project project = new Project();

                noteTest.Name = "Тестовая заметка";
                noteTest.NoteCategory = "Other";
                noteTest.NoteText = "Текст тестовой заметки";
                noteTest.CreationTime = DateTime.MinValue;
                noteTest.ModifiedTime = DateTime.Today;
            
            project.Notes.Add(noteTest);

            //Вызываем SaveToFile из класса ProjectManager
            ProjectManager.SaveToFIle(project, @"C:\Users\Голиков Юрий\NoteApp.txt");

            //Записываем данные из файла в переменную "project" при помощи метода LoadFromFile
            project = ProjectManager.LoadFromFile(@"C:\Users\Голиков Юрий\NoteApp.txt");

            Note item = new Note();

            for (var NoteNumber = 0; NoteNumber < project.Notes.Count; NoteNumber++)
            {
                //Записываем данные из списка Notes в переменную "item"
                 item = project.Notes[NoteNumber];
            }

            var name = noteTest.Name;
            var nameLoad = item.Name;
            Assert.AreEqual(name, nameLoad, "Если не возникает исключения, то тест пройден");

            var text = noteTest.NoteText;
            var textLoad = item.NoteText;
            Assert.AreEqual(text, textLoad, "Если не возникает исключения, то тест пройден");

            var category = noteTest.NoteCategory;
            var categoryLoad = item.NoteCategory;
            Assert.AreEqual(category, categoryLoad, "Если не возникает исключения, то тест пройден");

            var creationTime = noteTest.CreationTime;
            var creationTimeLoad = item.CreationTime;
            Assert.AreEqual(creationTime, creationTimeLoad, "Если не возникает исключения, то тест пройден");

            var modifiedTime = noteTest.ModifiedTime;
            var modifiedTimeLoad = item.ModifiedTime;
            Assert.AreEqual(modifiedTime, modifiedTimeLoad, "Если не возникает исключения, то тест пройден");

            project.Notes.Clear();
            System.IO.File.Delete(@"C:\Users\Голиков Юрий\NoteApp.txt");
        }
    }
}
