using Messages;
using Rhino.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProductor
{
    public class ProductorMessageConsumer : ConsumerOf<HelloMessage>
    {
        public void Consume(HelloMessage message)
        {
            Console.WriteLine(message.Mensaje);
        }
    }
}
