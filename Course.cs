using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Course
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public Course()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
        }

        public void Add(Teacher t)
        {
            teachers.Add(t);
        }

        public void Add(Student s)
        {
            students.Add(s);
        }

        public override string ToString()
        {
            string teaching = "";
            string studying = "";

            if (teachers.Count == 0) teaching = "noone";
            else
            {
                foreach(Teacher t in teachers)
                {
                    teaching += t.ToString() + ", ";
                }
            }

            if (students.Count == 0) studying = "noone";
            else
            {
                foreach (Student s in students)
                {
                    studying += s.ToString() + "\r\n";
                }
            }

            return teaching + "\r\nAre teaching:\r\n" + studying;
        }
    }
}
