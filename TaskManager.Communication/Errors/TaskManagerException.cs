using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Communication.Errors
{
    public class TaskManagerException : Exception
    {
        public TaskManagerException(string message) : base(message)
        {

        }
    }
}