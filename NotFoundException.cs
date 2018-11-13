using System.Collections.Generic;
using System.Net;

namespace Exceptions
{
    public class NotFoundException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        public NotFoundException(string name, object key)
            : this($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        public NotFoundException(string message)
        {
            ErrorDetails = new Models.ErrorDto
            {
                Message = message,
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
