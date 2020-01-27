using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseHandler ch = new CourseHandler();
            ch.WriteCourse();
            Console.ReadKey();
        }
    }
}
