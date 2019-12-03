using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс ProjectManager, содержащий методы SaveToFile и LoadFromFile
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Метод SaveToFile, который сериализует объект
        /// </summary>
        public static void SaveToFIle(Project Notes, string ProjectList)
        {
            ProjectList= JsonConvert.SerializeObject(Notes, Formatting.Indented);
            StreamWriter SW = new StreamWriter(new FileStream(@"C:\Users\Голиков Юрий\NoteApp.txt", FileMode.Create, FileAccess.Write));
            SW.Write(ProjectList);
            SW.Close();
        }

        /// <summary>
        /// Метод LoadFromFile, который десериализует объект
        /// </summary>
        public static void LoadFromFile(string ProjectList)
        {
                //Создаем переменную в которую помещаем результат десериализации
                Note note = null;

                //Создаем результат сериализации
                JsonSerializer serializer = new JsonSerializer();

                //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(@"C:\Users\Голиков Юрий\NoteApp.txt"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных 
                    note = (Note)serializer.Deserialize<Note>(reader);
                }
        }
    }
}
