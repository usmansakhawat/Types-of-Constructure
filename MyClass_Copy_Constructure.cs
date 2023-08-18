using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    public class MyClass_Copy_Constructure
    {
        public string name;
        public MyClass_Copy_Constructure(string name)
        {
            this.name = name;
        }
        public MyClass_Copy_Constructure(MyClass_Copy_Constructure copy)
        {
            this.name = copy.name;
        }
    }
}
