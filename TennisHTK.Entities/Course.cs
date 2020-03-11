using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    public class Course
    {
        private string name;

        public int ID { get; set; }
        public string Name 
        {
            get => name;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();
                else
                    name = value;
            }
        }
        public bool UnderRenovation { get; set; }
        public DateTime RenovationStart { get; set; }
    }
}
