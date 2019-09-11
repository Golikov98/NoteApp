using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    ///<symmary>Перечисление, содержащее категории заметки</symmary>
    public enum NoteCategoryEnum
    {
        Work,
        Home,
        HealthAndSports,
        People,
        Documents,
        Finance,
        Other
    }

    ///<symmary>
    ///Класс "Заметка", содержащий поля:«Название», «Категория заметки», 
    ///«Текст заметки», «Время создания», «Время последнего изменения».
    ///</symmary>
    public class Note:ICloneable
    {


        /// <summary>
        /// Метод для установки имени заметки.
        /// </summary>
        /// <param name="_name">Имя по умолчанию-"Без названия", длина имени не должна превышать 50 символов.</param>
        private string _name;

        public string GetName() { return _name; }

        //Выполяем проверку длины названия заметки
        public void SetName(string name)
        {
            if (name.Length <= 50)
            {
                if (name.Length == 0)
                {
                    name = "Без названия";
                }
            }
            else
            {
                throw new ArgumentException("Неверно введено имя заметки!");
            }
            _name = name;
        }

        /// <summary>
        /// Возвращает и задает категорию заметки.
        /// </summary>
        private string _noteCategory;

        public string GetNoteCategory() { return _noteCategory; }

        public  void SetNoteCategory(string noteCategory) { _noteCategory = noteCategory; }


        /// <summary>
        /// Возвращает и задает текст заметки.
        /// </summary>
        private string _noteText;

        public string GetNoteText() { return _noteText; }

        public void SetNoteText(string noteText) { _noteText = noteText; }

        /// <summary>
        /// Метод для установки даты создания заметки.
        /// </summary>
        /// <param name="_creationTime">
        /// Значение не должно быть больше текущей даты и времени.
        /// </param>
        private static DateTime _creationTime;

        public DateTime GetCreationTime() { return _creationTime; }

        public void SetCreationTime(DateTime creationTime)
        {
            if (creationTime > DateTime.Now)
            {
                throw new ArgumentException("Неверная дата создания заметки!");
            } else if (creationTime < DateTime.Today)
            {
                throw new ArgumentException("Неверная дата создания заметки!");
            }
            _creationTime = creationTime;
        }


        /// <summary>
        ///Метод для установки даты изменения заметки.
        /// </summary>
        /// <param name="_modifiedTime">
        /// Дата изменения заметки не должна быть меньше даты создания заметки.
        /// </param>
        private DateTime _modifiedTime;

        public DateTime GetModifiedTime() { return _modifiedTime; }

        public void SetModifiedTime(DateTime modifiedTime)
        {
            if (modifiedTime < _creationTime)
            {
                throw new ArgumentException("Неверная дата редактирования заметки!");
            }
            _modifiedTime = modifiedTime;
        }

        //Интерфейс клонирования заметок с одинаковыми названиями
        public object Clone()
        {
            return new Note { _name = this._name };
        }
    }
}
