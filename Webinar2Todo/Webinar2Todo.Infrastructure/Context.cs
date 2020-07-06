using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public Context(DbContextOptions<Context> options)
        :base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
