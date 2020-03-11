using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    public class Member
    {
        private string name;
        private string address;
        private string mobileNumber;
        private string email;
        private DateTime birthdate;
        private int points;

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
        public string Address 
        {
            get => address;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();
                else
                    address = value;
            }
        }
        public string MobileNumber 
        {
            get => mobileNumber;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException();
                else
                    mobileNumber = value;
            }
        }
        public string Email 
        {
            get => email;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();
                else
                    email = value;
            }
        }
        public DateTime Birthdate 
        {
            get => birthdate;
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Classifications { get; set; }
        public List<Classification> ListClassifications { get; set; }
        public int Points 
        {
            get => points;
            set
            {
                if (value > 0)
                    throw new ArgumentOutOfRangeException();
                else
                    points = value;
            }
        }

        public string GetClassificationsAsCSV()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var c in ListClassifications)
            {
                sb.Append($"{c.ID.ToString()},");
            }

            string output = sb.ToString();
            output.Remove(output.Length - 1, 1);
            return output;
        }
    }
}
