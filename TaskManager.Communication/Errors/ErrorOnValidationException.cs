using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Communication.Errors
{
    public class ErrorOnValidationException : TaskManagerException
    {
        public IList<string> Errors { get; set; }
        public ErrorOnValidationException(string message) : base(string.Empty)
        {
            Errors = [message];
        }

        public ErrorOnValidationException(IList<string> errors) : base(string.Empty)
        {
            Errors = errors;
        }
    }
}