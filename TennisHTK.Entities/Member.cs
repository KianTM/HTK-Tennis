using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Classification> Classifications { get; set; }
        public int Points { get; set; }
    }
}
