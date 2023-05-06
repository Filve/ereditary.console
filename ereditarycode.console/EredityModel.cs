namespace ereditarycode.console
{
    public class EredityModel
    {
        public int Id { get; set; }
        public string? CompleteName { get; set; }
        public SupremeEntity? SupremeEntity { get; set; }
        public OriginalFatherAndMother? orgnlFatherAndMother { get; set; }
        public OriginalFatherAndMotherChildren? orgnlChildren { get; set; }
        public OriginalWifeFromOtherFamily? orgnlWifesOfChildren { get; set; }
        public OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamily? orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily { get; set; }
        public OriginalChildrenFromFamily? orgnlChildrenFromFamily { get; set; }
        public OriginalHousbandAndWifeFromOriginalFatherAndMother? orgnlHousbandAndWifeFromOriginalFatherAndMotherFromFamily { get; set; }
        public OriginalChildOfHousbandAndWifeFromOriginalFatherAndMother? orgnlChildrenHousbandAndWifeFromOriginal { get; set; }
        public Children AllChildren { get; set; }

    }

    public class SupremeEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
        public OriginalFatherAndMother? orgnlFatherAndMother { get; set; }
        public Children? Childs { get; set; }

    }

    public class OriginalFatherAndMother
    {
        public int Id { get; set; }
        public string? OriginalFatherCompleteName { get; set; }
        public string? OriginalMotherCompleteSurname { get; set; }
        public string? ParentalChild { get; set; }

        public OriginalFatherAndMotherChildren? orgnlFatherAndMotherChilds { get; set; }

    }

    public class OriginalFatherAndMotherChildren
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

        public OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamily? orgnlHousbandAndWifeFromOthrFamilyAndOrgnlFamily { get; set; }

    }


    public class OriginalHousbandAndWifeFromOriginalFatherAndMotherAndOtherFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

        public OriginalChildrenFromFamily? orgnlChildrenHousbandAndWife { get; set; }
        public Children? Childs { get; set; }


    }

    public class OriginalChildrenFromFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
    }

    public class OriginalHousbandAndWifeFromOriginalFatherAndMother
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
        public Children? Childs { get; set; }
    }

    public class OriginalWifeFromOtherFamily
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

    }

    public class OriginalChildOfHousbandAndWifeFromOriginalFatherAndMother
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }

    }

    public class Children
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentalBond { get; set; }
        public int? Parental { get; set; }
    }
}