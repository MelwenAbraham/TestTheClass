using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTheClass
{
    public abstract class ParentClass
    {
        public int MyProperty { get; set; }

        public virtual void MyMethod()
        {
            Console.WriteLine("ParentClass.MyMethod()");
        }
    }
}
