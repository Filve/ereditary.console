using Microsoft.Extensions.Configuration;
using System.Data.Entity;
using System.Xml.Linq;

namespace ereditarycode.console
{
    public class DataContext : DbContext
    {
        IConfiguration configuration;

        public DataContext() : base("name=DbEredityString")
        {
        }

        public DbSet<SupremeEntities> SupremeEntities { get; set; }
        public DbSet<FaterAndMotherActual> FaterAndMotherActual { get; set; }
        public DbSet<FaterAndMotherOriginally> FaterAndMotherOriginally { get; set; }
        public DbSet<OriginallyRelashionship> OriginallyRelashionship { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Wifes> Wifes { get; set; }
        public DbSet<HousbandAndWifeOfFamily> HousbandAndWifeOfFamily { get; set; }
        public DbSet<FamilyMembers> FamilyMembers { get; set; }
        public DbSet<FamilyMember> FamilyMember { get; set; }

    }
}
