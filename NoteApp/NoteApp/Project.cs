using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, который хранит список заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes = new List<Note>();

        /// <summary>
        /// Хранение заметки
        /// </summary>
        public int CurrentIndexNote { get; set; }

        public List<Note> SortByModifiedTime()
        {
            return Notes.OrderByDescending(item => item.ModifiedTime).ToList();
        }
        public List<Note> SortByModifiedTime(NoteCategory category)
        {
            List<Note> SortedList = new List<Note>();
            SortedList = SortByModifiedTime().FindAll(t => t.Category == category);
            return SortedList;
        }
    }
}

