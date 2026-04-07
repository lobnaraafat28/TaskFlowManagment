using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Core.Entities
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public string? Description { get; set; }
        public string CreatorId {  get; set; }
        public ICollection<TaskItem> Tasks { get; set; } = new HashSet<TaskItem>();
        public ICollection<BoardUser> BoardUsers { get; set; } = new HashSet<BoardUser>();

    }
}
