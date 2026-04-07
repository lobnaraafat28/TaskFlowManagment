using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskFlow.Core.Enums;

namespace TaskFlow.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public TasksStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }

    }
}
