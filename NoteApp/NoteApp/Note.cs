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
        private string _text;
        
        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime _TimeWhenCreated;
       
        /// <summary>
        /// Время изменения
        /// </summary>
        private DateTime _TimeWhenChanged;

        /// <summary>
        /// Название заметки
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                //  Исключение не введенного названия
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("Name not writed");
                }
                
                //  Исключение если название больше 50 символов
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name bigger 50 symbols");  
                }
                _name = value;
            }
        }
        /// <summary>
        /// Содержание 
        /// </summary>
             public string Text { get; set; }

        /// <summary>
        /// Категории
        /// </summary>
        public NoteCategory Category { get; set; }
           
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime TimeWhenCreated { get; set; }
        /// <summary>
        /// Время последнего изменения
        /// </summary>
        public DateTime TimeWhenChanged { get; set; }

        /// <summary>
        /// Конструктор значений заметки.
        /// </summary>
        public Note(string name, string text, NoteCategory category)
        {
            Name = name;
            Text = text;
            Category = category;
            TimeWhenCreated = DateTime.Now;
            TimeWhenChanged = DateTime.Now;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

