using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    [Serializable]
    public class Project
    {
        public List<Note> Notes = new List<Note>();
    }
}
