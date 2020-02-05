using Microsoft.EntityFrameworkCore;
using PicturePlanner.Models;

namespace PicturePlanner.Data
{
    ///<summary>
    /// The database representation of our data model
    /// </summary>
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Thing> Things { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //object p = optionsBuilder.UseSqlServer("Server=.;Database=EntityFramework;Trusted_Connection=True;MultipleActiveResultSets=true"); // instead of trusted_connection UID= Password=
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
