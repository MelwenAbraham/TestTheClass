using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTheClass
{
    public class ChildClass : ParentClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("ChildClass.MyMethod()");
        }
    }
}
