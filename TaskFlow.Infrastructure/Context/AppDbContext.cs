using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskFlow.Core.Entities;
using TaskFlow.Infrastructure.Entities;
using TaskItem = TaskFlow.Core.Entities.TaskItem;

namespace TaskFlow.Infrastructure.Context
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<BoardUser> BoardUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BoardUser>().HasKey(b => new {b.BoardId, b.UserId});

            modelBuilder.Entity<BoardUser>().HasOne(b => b.Board).WithMany(bu => bu.BoardUsers).HasForeignKey(b => b.BoardId);
            modelBuilder.Entity<BoardUser>().HasOne<AppUser>().WithMany().HasForeignKey(b => b.UserId);
            modelBuilder.Entity<TaskItem>().HasOne(t => t.Board).WithMany(b => b.Tasks).HasForeignKey(t => t.BoardId);
            modelBuilder.Entity<Board>().HasOne<AppUser>().WithMany().HasForeignKey(b => b.CreatorId).OnDelete(DeleteBehavior.Restrict);

        }

    }
}
