﻿using System;
using System.Net;

namespace SmtpServer
{
    public interface ISessionContext
    {
        /// <summary>
        /// Fired when a command is about to execute.
        /// </summary>
        event EventHandler<SmtpCommandExecutingEventArgs> CommandExecuting;

        /// <summary>
        /// Fired when the session has been authenticated.
        /// </summary>
        event EventHandler<EventArgs> SessionAuthenticated;

        /// <summary>
        /// Gets the remote endpoint of the client.
        /// </summary>
        EndPoint RemoteEndPoint { get; }

        /// <summary>
        /// Returns a value indicating whether or not the current session is secure.
        /// </summary>
        bool IsSecure { get; }
    }
}