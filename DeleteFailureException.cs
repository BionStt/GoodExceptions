using System.Collections.Generic;
using System.Net;

namespace Exceptions
{
    public class DeleteFailureException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public DeleteFailureException(string name, object key)
            : this($"Deletion of entity \"{name}\" ({key}) failed.", new Dictionary<string, string[]>())
        {
        }

        public DeleteFailureException(string name, object key, IDictionary<string, string[]> failures)
            : this(name, key)
        {
            ErrorDetails.Failures = failures;
        }

        public DeleteFailureException(string message, IDictionary<string, string[]> failures)
        {
            ErrorDetails = new Models.ErrorDto
            {
                Message = message,
                Failures = failures
            };
        }
    }
}
