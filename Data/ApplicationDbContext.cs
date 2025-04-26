using Microsoft.EntityFrameworkCore;
using CentralizedDatabaseManagementSystem.Models;
using System.Collections.Generic;

namespace CentralizedDatabaseManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }

        public DbSet<Record> Records { get; set; }
    }
}
