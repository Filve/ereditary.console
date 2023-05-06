using System.Configuration;
using System.Data.Entity;

namespace ereditarycode.console
{
    public class Eredity : DbContext
    {
        public DbSet<EredityModel>? SupremeEntity { get; set; }
        public DbSet<SupremeEntity>? SupremeEntities { get; set; }
        public DbSet<FaterAndMother>? OriginalFatherAndMother { get; set; }
        public DbSet<FatherAndMotherChildren>? MotherAndFatherChildren { get; set; }
        public DbSet<WifesOfChildrenOfFatherAndMother>? WifeFromtOtherFamily { get; set; }
        public DbSet<HousbandAndWifeOfFamily>? Wifes { get; set; }
        public DbSet<FirstGenerationChildrenOfFamily>? HousbandAndWifeChildren { get; set; }
        public DbSet<FirstGenerationWifesOfChildrenOfFamily>? HousbandAndWife { get; set; }
        public DbSet<FirstGenerationHousbandAndWife>? ChildrenFromHousbandAndWife { get; set; }
        public DbSet<SecondGenerationChildrenOfFamily>? Children { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EredityModel>().MapToStoredProcedures(); 
        }

    }
}
