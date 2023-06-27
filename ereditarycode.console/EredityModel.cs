
namespace ereditarycode.console
{
    public class EredityModel
    {
        public SupremeEntities SupremeEntity { get; set; }
        public FaterAndMother FatherAndMother { get; set; }
        public Children Children { get; set; }
        public Wifes Wifes { get; set; }
        public HousbandAndWifeOfFamily HousbandAndWifeOfFamily { get; set; }
        public FamilyMembers FamilyMember { get; set; }
        public FamilyMember FamilyMembers { get; set; }

    }

    public class SupremeEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IndividualCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalCode { get => ParentalCode; set => AutoIncrementalGuild.AutoIncremental(ParentalCode); }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }

    }

    public class FaterAndMother
    {
        public int Id { get; set; }
        public string FatherCompleteName { get; set; }
        public string MotherCompleteName { get; set; }
        public int IndividualCode { get; set; }
        public int ParentalCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }

    }

    public class Children
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IndividualCode { get; set; }
        public int ParentalCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }



    }


    public class HousbandAndWifeOfFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ParentalCode { get; set; }
        public int IndividualCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }

    }

    public class FamilyMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ParentalCode { get; set; }
        public int IndividualCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
    }   
    
    public class FamilyMembers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ParentalCode { get; set; }
        public int IndividualCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
    }

    public class Wifes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ParentalCode { get; set; }
        public int IndividualCode { get; set; }
        public string ParentalBond { get => ParentalBond; set => ParentalBond = ParentalCode != 0 ? ParentalCode.ToString() : string.Empty; }
        public int ParentalConnectionCode { set => ParentalConnectionCode = ParentalBond != null ? ParentalCode * Convert.ToInt32(ParentalBond) : 0; }
        public DateTime CreationDate { get => CreationDate; set => CreationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }

    }
}