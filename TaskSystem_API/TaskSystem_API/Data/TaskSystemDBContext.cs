﻿using Microsoft.EntityFrameworkCore;
using TaskSystem_API.Data.Map;
using TaskSystem_API.Models;

namespace TaskSystem_API.Data
{
    public class TaskSystemDBContext : DbContext
    {
        public TaskSystemDBContext(DbContextOptions<TaskSystemDBContext> options)
            : base(options)
        {            
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
