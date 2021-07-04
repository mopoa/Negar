
using Microsoft.EntityFrameworkCore;
using Negar.Domain;

namespace Negar.Api
{


    public class NegarDbContext : DbContext
    {
        public NegarDbContext(DbContextOptions<NegarDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Art> Arts { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Designer> Designers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Packager> Packagers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Designer>().HasMany(e => e.Applications);
            modelBuilder.Entity<Application>().Ignore(app => app.Image);
            modelBuilder.Entity<Art>().Ignore(a => a.Picture);
            modelBuilder.Entity<Instrument>().Ignore(ins => ins.Picture);
            modelBuilder.Entity<User>().Ignore(u => u.UserPicture);
            modelBuilder.Entity<Process>().OwnsOne(e => e.Payment);
        }


    }
}