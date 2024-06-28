using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesSamples
{
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
    internal class DBMethodAttribute:Attribute
    {
        public DBMethodAttribute(string a)
        {
            this.message = a;
        }

        public string message { get; private set; }
    }
}
