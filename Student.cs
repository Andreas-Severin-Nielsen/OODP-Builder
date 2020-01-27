using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return name;
        }
    }
}
