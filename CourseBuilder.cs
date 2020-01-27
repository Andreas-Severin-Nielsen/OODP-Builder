using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CourseBuilder : ICourseBuilder
    {
        public CourseBuilder()
        {
            Course = new Course();
        }

        public Course Course { get; }

        public void BuildStudent(string name)
        {
            Course.Add(new Student(name));
        }

        public void BuildTeacher(string name)
        {
            Course.Add(new Teacher(name));
        }
    }
}
