using Microsoft.EntityFrameworkCore;

namespace Simuladoprovajava.Entities;


    public class SimuladoprovajavaDbContext(DbContextOptions options): DbContext(options)
    {
    public DbSet<User> Users => Set<User>();
        public DbSet<Fanfic> Fanfics => Set<Fanfic>();
        public DbSet<Shelf> Shelves => Set<Shelf>();

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>();

            model.Entity<Fanfic>()
                .HasOne(a => a.Author)
                .WithMany(f => f.Fanfics)
                .HasForeignKey(a => a.AuthorID)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Fanfic>()
                .HasOne(s => s.Shelf)
                .WithMany(f => f.Fanfics)
                .HasForeignKey(s => s.ShelfID)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Shelf>()
                .HasOne(o => o.Owner)
                .WithMany(s => s.Shelves)
                .HasForeignKey(o => o.OwnerID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
