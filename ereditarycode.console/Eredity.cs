using System.Configuration;
using System.Data.Entity;

namespace ereditarycode.console
{
    public class Eredity : DbContext
    {
        public Eredity() : base("name=DbEredityString") { }

        public DbSet<EredityModel> EredityModel { get; set; }
        public DbSet<SupremeEntites> SupremeEntities { get; set; }
        public DbSet<FaterAndMother> FaterAndMother { get; set; }
        public DbSet<FatherAndMotherChildren> FatherAndMotherChildren { get; set; }
        public DbSet<WifesOfChildrenOfFatherAndMother> WifesOfChildrenOfFatherAndMother { get; set; }
        public DbSet<HousbandAndWifeOfFamily> HousbandAndWifeOfFamily { get; set; }
        public DbSet<FirstGenerationChildrenOfFamily> FirstGenerationChildrenOfFamily { get; set; }
        public DbSet<FirstGenerationWifesOfChildrenOfFamily> FirstGenerationWifesOfChildrenOfFamily { get; set; }
        public DbSet<FirstGenerationHousbandAndWife> FirstGenerationHousbandAndWife { get; set; }
        public DbSet<SecondGenerationChildrenOfFamily> SecondGenerationChildrenOfFamily { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EredityModel>().MapToStoredProcedures();
        }

    }
}
