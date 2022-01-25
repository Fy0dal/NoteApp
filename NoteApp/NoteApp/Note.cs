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
                if (value.Length >= 50)
                {
                    throw new ArgumentException("Name of note more 50 symbol");
                }
                else
                {
                    if (value != "")
                    {
                        _name = value;
                    }
                    else _name = "Name not writed";
                }
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
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// Время последнего изменения
        /// </summary>
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Конструктор значений заметки.
        /// </summary>
        public Note(string name, string text, NoteCategory category)
        {
            Name = name;
            Text = text;
            Category = category;
            CreatedTime = DateTime.Now;
            ModifiedTime = DateTime.Now;
        }
        public Note()
        {

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Сравнивает значения двух заметок
        /// </summary>
        /// <param name="obj">Заметка, с которой идет сравнение</param>
        /// <returns>true, если все поля одной заметки совпадают с другой, иначе - false</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Note other))
            {
                return false;
            }

            return Name == other.Name && Text == other.Text && Category == other.Category &&
                CreatedTime == other.CreatedTime && ModifiedTime == other.ModifiedTime;
        }
    }
}

