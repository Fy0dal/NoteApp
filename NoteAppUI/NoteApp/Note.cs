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
        private string _name;
        private NoteCategory _category;
        private string _notetext;
        private DateTime __DateofCreateon;
        private DateTime _DateofLastEdit;
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("Name not writed");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name bigger 50 simvols");
                   
                }
                _name = value;
            }
        }
             public string NoteText
        {
            get 
            { 
                return _notetext; 
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Text not writed");
                }
                _notetext = value;
            }
        }
        public NoteCategory Category
        {
            get 
            { 
                return _category; 
            }
            set 
            {
                _category = value; 
            }
        }
        public DateTime DateofCreation
        {
            get 
            { 
                return __DateofCreateon; 
            }
            set {
                __DateofCreateon = value; 
            }
        }

        public DateTime DateOfLastEdit
        {
            get {
                return _DateofLastEdit; 
            }
            set {
                _DateofLastEdit = value; 
            }
        }
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

