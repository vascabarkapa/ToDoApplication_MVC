using Microsoft.EntityFrameworkCore;
using ToDoApplication_MVC.Models;

namespace ToDoApplication_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
