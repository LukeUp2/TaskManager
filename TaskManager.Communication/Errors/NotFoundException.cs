using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Communication.Errors
{
    public class NotFoundException : TaskManagerException
    {
        public string Error { get; set; }
        public NotFoundException(string message) : base(string.Empty)
        {
            Error = message;
        }
    }
}