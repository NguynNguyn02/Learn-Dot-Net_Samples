using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectSamples
{
    public class MessageWrite : IMessageWriter
    {
        private readonly INullInterface _nullInterface;

        public MessageWrite(INullInterface nullInterface)
        {
            _nullInterface = nullInterface;
        }
        public void Write(string message)
        {
            _nullInterface.DoSomeThing();
            Console.WriteLine(message);
        }
    }
}
