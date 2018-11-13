using System.Collections.Generic;
using System.Net;

namespace Exceptions
{
    public class CreateFailureException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public CreateFailureException(string name)
        {
            ErrorDetails = new Models.ErrorDto
            {
                Message = $"Creation of entity \"{name}\" failed.",
                Failures = new Dictionary<string, string[]>()
            };
        }

        public CreateFailureException(string name, IDictionary<string, string[]> failures) : this(name)
        {
            ErrorDetails.Failures = failures;
        }
    }
}
