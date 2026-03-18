using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Enuns;

namespace TaskManager.Communication.Requests
{
    public class UpdateTaskRequestJson
    {
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public PriorityEnum? Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public StatusEnum? Status { get; set; }

    }
}