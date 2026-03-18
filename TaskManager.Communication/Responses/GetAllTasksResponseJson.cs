using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Communication.Responses
{
    public class GetAllTasksResponseJson
    {
        public List<TaskShortResponseJson> Tasks { get; set; } = [];
    }
}