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
    /// Класс ProjectManager, содержащий методы Serialization и Deserialization
    /// </summary>
    public class ProjectManager
    {
        //private static string DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/NoteApp.txt";

        /// <summary>
        /// Метод Serialization, который сериализует объект
        /// </summary>
        public static void SaveToFIle()
        {
            Project project = new Project();
            string ProjectList= JsonConvert.SerializeObject(project.Notes, Formatting.Indented);
            StreamWriter SW = new StreamWriter(new FileStream(@"C:\Users\Голиков Юрий\NoteApp.txt", FileMode.Create, FileAccess.Write));
            SW.Write(ProjectList);
            SW.Close();

            /*Project project = new Project();
            Note note = new Note();
            //Создаем экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Голиков Юрий\NoteApp.txt"))
            using (JsonWriter writer=new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, note);
            }*/
        }

        /// <summary>
        /// Метод Deserialization, который десериализует объект
        /// </summary>
        public static void Deserialization()
        {
            //Создаем переменную в которую помещаем результат десериализации
            Note note = null;

            //Создаем результат сериализации
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@"\My Documents\NoteApp.notes"))
            using(JsonReader reader=new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных 
                note = (Note)serializer.Deserialize<Note>(reader);
            }
        }
    }
}
