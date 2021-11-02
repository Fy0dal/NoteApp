using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;
using Newtonsoft.Json;
namespace NoteApp
{
    /// <summary>
    /// Класс заметки.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название
        /// </summary>
        private string _name;
        /// <summary>
        /// Категория
        /// </summary>
        private NoteCategory _category;
        /// <summary>
        /// Текст
        /// </summary>
        private string _notetext;
        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime __DateofCreateon;
        /// <summary>
        /// Время изменения
        /// </summary>
        private DateTime _DateofLastEdit;

        /// <summary>
        /// Название заметки и исключения
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                /// <summary>
                ///  Исключение не введенного названия
                /// <summary>
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("Name not writed");
                }
                /// <summary>
                ///  Исключение если название больше 50 символов
                /// <summary>
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name bigger 50 simvols");
                   
                }
                _name = value;
            }
        }
        /// <summary>
        /// Содержание и исключение
        /// </summary>
             public string NoteText { get; set; }

        /// <summary>
        /// Категории
        /// </summary>
        public NoteCategory Category { get; set; }
           
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateofCreation { get; set; }
        /// <summary>
        /// Время последнего изменения
        /// </summary>
        public DateTime DateOfLastEdit { get; set; }

        /// <summary>
        /// Конструктор значений заметки.
        /// </summary>
        public Note(string name, string notetext, NoteCategory category)
        {
            Name = name;
            NoteText = notetext;
            Category = category;
            DateofCreation = DateTime.Now;
            DateOfLastEdit = DateTime.Now;

        }




    }
    

}

