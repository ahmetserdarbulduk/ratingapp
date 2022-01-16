using Microsoft.EntityFrameworkCore;
using RatingApp.Entities.Concrete;

namespace RatingApp.DataAccess.Concrete.EntityFramework{
    public class RatingAppContext:DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=RatingApp;Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}