using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Core.Entities;

namespace TaskFlow.Infrastructure.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }

    }
}

