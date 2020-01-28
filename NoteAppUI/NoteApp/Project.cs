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

        ///<summary>
        ///Метод, сортирующий список заметок от новейшей к старшей (по времени редактирования заметки)
        ///</summary>        
        public void SortedModifiedTimeNew()
        {
            Notes.Sort((x, y) => y.ModifiedTime.CompareTo(x.ModifiedTime));
        }

        ///<summary>
        ///Метод, сортирующий список заметок от старшей к новейшей (по времени редактирования заметки)
        ///</summary> 
        public void SortedModifiedTimeOld()
        {
            Notes.Sort((x, y) => x.ModifiedTime.CompareTo(y.ModifiedTime));
        }

        /// <summary>
        /// Перегруженный метод, фильтрующий список заметок по категории заметки и сортирующий список SortResult
        /// по времени редактирования заметки
        /// </summary>
        public List<Note> SortedNoteForNoteCtaegory(string Category)
        {
            List<Note> SortResult = (from item in Notes where item.NoteCategory == Category select item).ToList();
            SortResult.Sort((x, y) => y.ModifiedTime.CompareTo(x.ModifiedTime));
            SortedResult = SortResult;
            return SortResult;
        }

        public List<Note> SortedResult;

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
