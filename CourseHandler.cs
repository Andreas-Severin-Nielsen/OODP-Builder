using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CourseHandler
    {
        ICourseBuilder courseBuilder;
        Course course;

        public CourseHandler()
        {
            courseBuilder = new CourseBuilder();
            courseBuilder.BuildStudent("Bridget Theriveaquai");
            courseBuilder.BuildTeacher("Hank R. Cheef");
            courseBuilder.BuildTeacher("Ev R. Lasting");
            courseBuilder.BuildStudent("Constance Noring");
            courseBuilder.BuildStudent("Ty Ayelloribbin");
            course = courseBuilder.Course;
        }

        public void WriteCourse()
        {
            Console.WriteLine(course.ToString());
        }
    }
}
