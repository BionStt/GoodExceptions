using System.Collections.Generic;
using System.Net;

namespace Exceptions
{
    public class ActionWasDeniedException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.Forbidden;

        public ActionWasDeniedException(string message = null)
        {
            ErrorDetails = new Models.ErrorDto
            {
                Message = $"Action was denied! {message}",
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
