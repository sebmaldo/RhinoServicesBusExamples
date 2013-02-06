using Messages;
using Rhino.ServiceBus;
using Rhino.ServiceBus.Hosting;
using Rhino.ServiceBus.Msmq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace ConsoleProductor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureQueues.Prepare("msmq://localhost/prueba.consola.productor", QueueType.Standard);

            var host = new DefaultHost();
            host.Start<ProductorBootStrapper>();

            var bus = host.Bus as IServiceBus;

            Console.WriteLine("Enter para enviar el mensaje");
            Console.ReadLine();

            bus.Send(new HelloMessage
            {
                Mensaje = "Hola desde el consumidor"
            });

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
