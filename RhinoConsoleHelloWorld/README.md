Ejemplo de Consola de Rhino Services Bus
----------------------------------------

En este ejemplo se realizará una aplicación de consola (Productor) que enviará mensajes a otra aplicación de consola (Consumer).

Utilizando una librería de clases de mensajes (Messages) y una librería utilitaria (Utils).

###Configuracion###
Para esto como configuración hay que seguir los siguientes pasos.

1. Instalar o habilitar el sistema de colas de windows MSMQ.
2. Instalar el paquete de rhino services bus con nuget. ***Install-Package Rhino.ServiceBus***. Hay que hacer esto para los proyectos Productor, Consumer y Utils.

