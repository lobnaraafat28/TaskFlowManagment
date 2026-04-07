using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Core.Enums;

namespace TaskFlow.Core.Entities
{
    public class BoardUser
    {
        public int BoardId { get; set; }
        public Board Board { get; set; }

        public string UserId { get; set; }

        public BoardRole Role { get; set; }
    }
}
