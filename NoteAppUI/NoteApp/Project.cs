using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, который хранит словарь всех созданных заметок.
    /// </summary>
    public class Project
    {


        private List<Note> _notes = new List<Note>();

        public List<Note> Notes
        {
            get { return _notes; }
            set => _notes = value;
        }

    }
}
