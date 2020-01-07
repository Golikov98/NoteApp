using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
    [Serializable]
    public class Note:ICloneable
    {


        /// <summary>
        /// Метод для установки имени заметки.
        /// </summary>
        /// <param name="_name">Имя по умолчанию-"Без названия", длина имени не должна превышать 50 символов.</param>
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

                //Выполняем проверку длины имени заметки
                if (_name.Length <= 50)
                {
                    if (_name.Length == 0)
                    {
                        _name = "Без названия";
                    }
                }
                else
                {
                    throw new ArgumentException("Имя заметки более 50 символов!");
                }
            }
        }


        /// <summary>
        /// Возвращает и задает категорию заметки.
        /// </summary>
        private string _noteCategory;

        public string NoteCategory
        {
            get
            {
                return _noteCategory;
            }
            set
            {
                _noteCategory = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текст заметки.
        /// </summary>
        private string _noteText;

        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
            }
        }

        /// <summary>
        /// Метод для установки даты создания заметки.
        /// </summary>
        /// <param name="_creationTime">
        /// Значение не должно быть больше текущей даты и времени.
        /// </param>
        private static DateTime _creationTime;

        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
            set
            {
                _creationTime = value;

                //Проверяем дату создания заметки
                if (_creationTime > DateTime.Now)
                {
                    throw new ArgumentException("Неверная дата создания заметки!");
                }
            }
        }

        /// <summary>
        ///Метод для установки даты изменения заметки.
        /// </summary>
        /// <param name="_modifiedTime">
        /// Дата изменения заметки не должна быть меньше даты создания заметки.
        /// </param>
        private DateTime _modifiedTime;

        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedTime;
            }
            set
            {
                _modifiedTime = value;

                //Проверяем дату редактирования заметки
                if (_modifiedTime < _creationTime)
                {
                    throw new ArgumentException("Неверная дата редактирования заметки!");
                }
            }
        }

        //Интерфейс клонирования заметок с одинаковыми названиями
        public object Clone()
        {
            return new Note { _name = this._name };
        }
    }
}
