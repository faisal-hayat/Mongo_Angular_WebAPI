using Microsoft.EntityFrameworkCore;
using MongDbWebAPI.Models;

namespace MongDbWebAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        }
        // This is where we will be adding the models
        public DbSet<Driver> Drivers { get; set; }
    }
}
