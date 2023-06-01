using Microsoft.EntityFrameworkCore;
using immobile.Api.Entities;
namespace immobile.Api.Infraestructs;

public class AppDbContext : DbContext{
    public DbSet<AddressEntity> Address { get; set; }
    public DbSet<ContactEntity> Contact { get; set; }
    public DbSet<ImmobileEntity> Immobile { get; set; }
    public DbSet<PriceEntity> Price { get; set; }

    public DbSet<TagCommonAreaEntity> TagCommonArea { get; set; }
    public DbSet<TagPrivateAreaEntity> TagPrivateArea { get; set; }
    public DbSet<TagBusinessEntity> TagBusiness { get; set; }
    public DbSet<TagAdvertiseTypeEntity> TagAdvertiseType { get; set; }
    public DbSet<TagImmobileTypeEntity> TagImmobileType { get; set; }


    public DbSet<Contact_and_immobile> Contact_and_immobile { get; set; }
    public DbSet<TagAdvertiseType_and_immobile> TagAdvertiseType_and_immobile { get; set; }
    public DbSet<TagCommonArea_and_Immobile> TagCommonArea_and_Immobile { get; set; }
    public DbSet<TagPrivateArea_and_immobile> TagPrivateArea_and_immobile { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost,1450;Initial Catalog=Immobile;Password=#Lisboa1206; User ID=SA;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact_and_immobile>().HasKey(ci => new { ci.ContactId, ci.ImmobileId });
        modelBuilder.Entity<TagAdvertiseType_and_immobile>().HasKey(ci => new { ci.TagAdvertiseTypeId, ci.ImmobileId });
        modelBuilder.Entity<TagCommonArea_and_Immobile>().HasKey(ci => new { ci.TagCommonAreaId, ci.ImmobileId });
        modelBuilder.Entity<TagPrivateArea_and_immobile>().HasKey(ci => new { ci.TagPrivateAreaId, ci.ImmobileId });

    }
}