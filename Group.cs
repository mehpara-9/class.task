using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.task
{
    public class Group
    {
        public string Name { get; set; }
        public string Shift { get; set; }

        public Student[] Students { get; set; }

        public Group(string name,string shift)
        {
            Name = name;
            Shift = shift;
        }


        public void AddStudent(Student student,string group)
        {
            Student[] NewStudents = new Student[Students.Length + 1];
            NewStudents[Students.Length] = student;

            Students = NewStudents;
        }

        public string FindStudent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    return $"Name:{Students[0].Name},Surname:{Students[0].Surname},Gender:{Students[0].Gender},Age:{Students[0].Age},PhoneNumber:{Students[0].PhoneNumber},Limit:{Students[0].Limit}";
                }
            }
            return $"{name} adli telebe yoxdur";
        }
    }
}
