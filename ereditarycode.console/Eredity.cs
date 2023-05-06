using System.Configuration;
using System.Data.Entity;

namespace ereditarycode.console
{
    public class Eredity : DbContext
    {
        public DbSet<EredityModel>? SupremeEntity { get; set; }
        public DbSet<SupremeEntity>? SupremeEntities { get; set; }
        public DbSet<OriginalFatherAndMother>? OriginalFatherAndMother { get; set; }
        public DbSet<OriginalFatherAndMotherChildren>? MotherAndFatherChildren { get; set; }
        public DbSet<OriginalWifeFromOtherFamily>? WifeFromtOtherFamily { get; set; }
        public DbSet<OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamily>? Wifes { get; set; }
        public DbSet<OriginalChildrenFromFamily>? HousbandAndWifeChildren { get; set; }
        public DbSet<OriginalHousbandAndWifeFromOriginalFatherAndMother>? HousbandAndWife { get; set; }
        public DbSet<OriginalChildOfHousbandAndWifeFromOriginalFatherAndMother> OriginalChildrenFromHousbandAndWife { get; set; }
        public DbSet<Children>? Children { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EredityModel>().MapToStoredProcedures(); 
        }

    }
}
