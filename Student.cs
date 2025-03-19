using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.task
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        private int _limit;
        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                if (value > 0)
                {
                    _limit = value;
                }
                else
                {
                    Console.WriteLine("Limit  0 dan asagi olmamalidir");
                }
            }
        }
        public string Group { get; set; }

        public Student(string Name, string Surname, string Gender, int Age, string PhoneNumber, int Limit)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.Limit = Limit;
        }

        public string Absent()
        {
            if (Limit != 0)
            {
                Limit--;
                return "Telebe derse gelmeyib";
            }
            else
            {

                return "Kesildiniz";
            }




        }

    }
}
