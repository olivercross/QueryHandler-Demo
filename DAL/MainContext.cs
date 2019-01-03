using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QueryHandler.Models;

namespace QueryHandler.DataAccess
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Audit> Audit { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Audit>().HasData(
                new List<Audit>
                {
                    new Audit{Id =  1, DateCreated = DateTime.Now, AuditType = "Default", AuditState = AuditState.InProgress },
                    new Audit{Id =  2, DateCreated = DateTime.Now.AddDays(-1), AuditType = "section 1", AuditState = AuditState.InProgress },
                    new Audit{Id =  3, DateCreated = DateTime.Now.AddDays(-2), AuditType = "Default", AuditState = AuditState.InProgress },
                    new Audit{Id =  4, DateCreated = DateTime.Now.AddDays(-3), AuditType = "Default", AuditState = AuditState.Complete },
                    new Audit{Id =  5, DateCreated = DateTime.Now.AddDays(-4), AuditType = "Default", AuditState = AuditState.InProgress }
                });
        }
    }
}