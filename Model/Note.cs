using System;

namespace CatsJournal.Model
{
    public class Note
    {
        public int Id { get; set; } // id
        public string Name { get; set; } // название заметки
        public List<string> Descriptions { get; set; } // описания
        public List<string> Images { get; set; } // картиночки
    }
}
