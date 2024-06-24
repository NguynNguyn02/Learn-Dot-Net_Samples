using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectSamples
{
    public class NullInterface : INullInterface
    {
        public void DoSomeThing()
        {
            Console.WriteLine("Hello");
        }
    }
}
