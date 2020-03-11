using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Name 
        {
            get => Name;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();
                else
                    Name = value;
            }
        }
        public bool UnderRenovation { get; set; }
        public DateTime RenovationStart { get; set; }
    }
}
