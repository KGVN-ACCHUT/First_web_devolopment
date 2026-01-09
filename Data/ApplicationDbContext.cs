using Microsoft.EntityFrameworkCore;
using First_web_devolepment.Models;

namespace First_web_devolepment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }            
        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
