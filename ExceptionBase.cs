using Exceptions.Models;
using System;
using System.Net;

namespace Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public ErrorDto ErrorDetails { get; protected set; }
        public abstract HttpStatusCode StatusCode { get; }
    }
}
