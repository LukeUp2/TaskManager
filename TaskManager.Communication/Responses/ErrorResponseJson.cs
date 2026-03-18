using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Communication.Responses
{
    public class ErrorResponseJson
    {
        public List<string> Errors { get; set; } = [];
    }
}