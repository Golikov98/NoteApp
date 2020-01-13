using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта
    /// </summary>
    [Serializable]
    public class Project 
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /*public void SortedModifiedTimeNew()
        {
            Notes.Sort((x, y) => x.CreationTime.CompareTo(y.CreationTime));
        }
        public void SortedModifiedTimeOld()
        {
            Notes.Sort((x, y) => y.CreationTime.CompareTo(x.CreationTime));
        }*/

        private Note _currentNote;

        public Note CurrentNote
        {
            get
            {
                return _currentNote;
            }
            set
            {
                _currentNote = value;
            }
        }
    }
}
