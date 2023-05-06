namespace ereditarycode.console
{
    public class EredityModel
    {
        public int Id { get; set; }
        public string? CompleteName { get; set; }
        public SupremeEntity? SupremeEntity { get; set; }
        public FaterAndMother? FatherAndMother { get; set; }
        public FatherAndMotherChildren? FatherAndMotherChildren { get; set; }
        public WifesOfChildrenOfFatherAndMother? WifesOfChildrenOfFatherAndMother { get; set; }
        public HousbandAndWifeOfFamily? HousbandAndWifeOfFamily { get; set; }
        public FirstGenerationChildrenOfFamily? FirstGenerationChildrenOfFamily { get; set; }
        public FirstGenerationWifesOfChildrenOfFamily? FirstGenerationWifesOfChildrenOfFamily { get; set; }
        public FirstGenerationHousbandAndWife? FirstGenerationHousbandAndWife { get; set; }
        public SecondGenerationChildrenOfFamily? SecondGenerationChildrenOfFamily { get; set; }

    }

    public class SupremeEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
        public FaterAndMother? FatherAndMother { get; set; }

    }

    public class FaterAndMother
    {
        public int Id { get; set; }
        public string? OriginalFatherCompleteName { get; set; }
        public string? OriginalMotherCompleteSurname { get; set; }
        public string? ParentalChild { get; set; }

        public FatherAndMotherChildren? FatherAndMotherChilds { get; set; }

    }

    public class FatherAndMotherChildren
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

        public HousbandAndWifeOfFamily? HousbandAndWifeFromFamily { get; set; }

    }


    public class HousbandAndWifeOfFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

        public FirstGenerationChildrenOfFamily? ChildrenHousbandAndWife { get; set; }


    }

    public class FirstGenerationChildrenOfFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
    }

    public class FirstGenerationWifesOfChildrenOfFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
    }

    public class WifesOfChildrenOfFatherAndMother
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

    }

    public class FirstGenerationHousbandAndWife
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

        public SecondGenerationChildrenOfFamily secondGenerationChildren { get; set; }

    }

    public class SecondGenerationChildrenOfFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
    }
}