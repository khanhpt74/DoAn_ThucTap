using Microsoft.EntityFrameworkCore;
using DoAn_ThucTap.Models;
using DoAn_ThucTap.Models.Domain;

namespace DoAn_ThucTap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}