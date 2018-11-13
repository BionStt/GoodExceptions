using System.Collections.Generic;

namespace Exceptions.Models
{
    public class ErrorDto
    {
        public string Message { get; set; }
        public IDictionary<string, string[]> Failures { get; set; }
    }
}
