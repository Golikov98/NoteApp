using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        Project project = new Project();
        static void Serialization()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"\My Documents\NoteApp.notes")) ;
           // using (JsonWriter writer=new JsonTextWriter(sw))
            //{
            //    serializer.Serialize(writer, Notes);
            //}
        }
    }
}
