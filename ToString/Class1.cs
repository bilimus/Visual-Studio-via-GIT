using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class MyClass
    {
        public string Name {set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
