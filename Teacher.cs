using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Teacher
    {
        private string name;

        public Teacher(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return "Professor " + name;
        }
    }
}
