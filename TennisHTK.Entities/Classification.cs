using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    public class Classification
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
    }
}
