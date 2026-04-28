using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Core.Enums;

namespace TaskFlow.Services.DTOs
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public TasksStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
    }
}
