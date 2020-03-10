using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool UnderRenovation { get; set; }
        public DateTime RenovationStart { get; set; }
    }
}
