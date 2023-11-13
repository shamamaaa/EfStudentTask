using EfTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EfTask.DAL
{
	public class AppDbContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=StudentEfTask;User Id=SA;Password=S@mama123;trusted_connection=false;Encrypt=false");
        }


        public DbSet<Student> Students { get; set; }
    }
}

