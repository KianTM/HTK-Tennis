using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public Member[] Reservants { get; set; } = new Member[2];
        public Course Course { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime 
        {
            get => EndTime;
            set
            {
                if (value < StartTime)
                    throw new ArgumentOutOfRangeException();
                else
                    EndTime = value;
            }
        }
    }
}
