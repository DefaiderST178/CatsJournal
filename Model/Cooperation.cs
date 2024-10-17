using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsJournal.Model
{
    public class Cooperation
    {
        public string Name { get; set; } // С кем сотрудничаем (наименование)
        public string Description { get; set; } // кратко описать
        public string Address { get; set; } // адрес
        public string Phone { get; set; } // телефон
        public string Website { get; set; } // сайт
    }
}
