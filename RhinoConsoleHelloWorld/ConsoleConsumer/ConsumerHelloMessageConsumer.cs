using Messages;
using Rhino.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsumer
{
    public class ConsumerHelloMessageConsumer : ConsumerOf<HelloMessage>
    {
        private readonly IServiceBus _serviceBus;

        public ConsumerHelloMessageConsumer(IServiceBus servicesBus)
        {
            _serviceBus = servicesBus;
        }


        public void Consume(HelloMessage message)
        {
            Console.WriteLine(message.Mensaje);

            _serviceBus.Reply(new HelloMessage
            {
                Mensaje= "Hola desde el otro lado"
            });

        }
    }
}
