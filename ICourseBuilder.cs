using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface ICourseBuilder
    {
        
        void BuildStudent(string name);
        void BuildTeacher(string name);

        Course Course { get; }


    }
}
