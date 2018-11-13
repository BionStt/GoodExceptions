using Emj.Application.Exceptions.Models;
using System.Collections.Generic;
using System.Net;

namespace Exceptions
{
    public class UploadedFileIsEmptyException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NoContent;

        public UploadedFileIsEmptyException()
        {
            ErrorDetails = new ErrorDto
            {
                Message = "Could not find sent files.",
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
