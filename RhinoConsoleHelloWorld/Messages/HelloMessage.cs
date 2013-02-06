﻿namespace Messages
{
    /// <summary>
    /// Clase de firma de mensajes para ser utilizada enviando y resiviendo los mensajes de ese tipo.
    /// </summary>
    public class HelloMessage
    {
        /// <summary>
        /// Mensaje para ser intercambiado entre las diferentes soluciones.
        /// </summary>
        public string Mensaje { get; set; }
    }
}
