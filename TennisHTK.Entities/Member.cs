﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisHTK.Entities
{
    class Member
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
        public string Address 
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
        public string MobileNumber 
        {
            get => MobileNumber;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException();
                else
                    MobileNumber = value;
            }
        }
        public string Email 
        {
            get => Email;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();
                else
                    Email = value;
            }
        }
        public DateTime Birthdate { get; set; }
        public List<Classification> Classifications { get; set; }
        public int Points 
        {
            get => Points;
            set
            {
                if (value > 0)
                    throw new ArgumentOutOfRangeException();
                else
                    Points = value;
            }
        }

        public string GetClassificationsAsCSV()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var c in Classifications)
            {
                sb.Append($"{c.ID.ToString()},");
            }

            string output = sb.ToString();
            output.Remove(output.Length - 1, 1);
            return output;
        }
    }
}
