using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSamples
{
    //[Obsolete("Day la Obsolete")]
    internal class Class1
    {
        [DBMethod("Customer")]
        public void PrintHelloWorld1()
        {
            Console.WriteLine("Hello,Customer");

        }
        [DBMethod("User")]

        public void PrintHelloWorld2()
        {
            Console.WriteLine("Hello,User");

        }
    }
}
