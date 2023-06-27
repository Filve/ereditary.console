using System.Configuration;
using System.Data.Entity;

namespace ereditarycode.console
{
    public class Eredity : DbContext
    {
        public Eredity() : base("name=DbEredityString") { }

        public DbSet<SupremeEntities> SupremeEntities { get; set; }
        public DbSet<FaterAndMother> FaterAndMother { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Wifes> Wifes { get; set; }
        public DbSet<HousbandAndWifeOfFamily> HousbandAndWifeOfFamily { get; set; }
        public DbSet<FamilyMembers> FamilyMembers { get; set; }
        public DbSet<FamilyMember> FamilyMember { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupremeEntities>().MapToStoredProcedures();
            modelBuilder.Entity<FaterAndMother>().MapToStoredProcedures();
            modelBuilder.Entity<Children>().MapToStoredProcedures();
            modelBuilder.Entity<Wifes>().MapToStoredProcedures();
            modelBuilder.Entity<HousbandAndWifeOfFamily>().MapToStoredProcedures();
            modelBuilder.Entity<FamilyMember>().MapToStoredProcedures();
            modelBuilder.Entity<FamilyMembers>().MapToStoredProcedures();
        }

    }
}
