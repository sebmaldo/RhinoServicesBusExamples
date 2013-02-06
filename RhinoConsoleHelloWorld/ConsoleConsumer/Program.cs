using Rhino.ServiceBus.Hosting;
using Rhino.ServiceBus.Msmq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureQueues.Prepare("msmq://localhost/pruebas.consola.consumidor", QueueType.Standard);

            Console.WriteLine("Esperando los mensajes entrantes...");

            var host = new DefaultHost();

            host.Start<ConsumerBootStrapper>();

            Console.ReadLine();
        }
    }
}
