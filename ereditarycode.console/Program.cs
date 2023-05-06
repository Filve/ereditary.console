// See https://aka.ms/new-console-template for more information
using ereditarycode.console;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


var name = "";
var surname = "";
var namemother = "";
var parentalbond = "";
var parental = 0;

var swtch = "";
var findNumberOfParental = 0;

switch (swtch)
{
    case "supreme":
        using (var context = new Eredity())
        {
            var db = new SupremeEntity()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond,

            };
            context?.SupremeEntities?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "fatherANDmother":
        using (var context = new Eredity())
        {
            var db = new FaterAndMother()
            {
                OriginalFatherCompleteName = name + " " + surname,
                OriginalMotherCompleteSurname = namemother,
                ParentalChild = parentalbond
            };
            context?.OriginalFatherAndMother?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "childrenOfFatherAndMother":
        using (var context = new Eredity())
        {
            var db = new FatherAndMotherChildren()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond

            };
            context?.MotherAndFatherChildren?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "wifes":
        using (var context = new Eredity())
        {
            var db = new WifesOfChildrenOfFatherAndMother()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond

            };
            context?.WifeFromtOtherFamily?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "HousbandAndWife":
        using (var context = new Eredity())
        {
            var db = new FirstGenerationWifesOfChildrenOfFamily()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond

            };
            context?.HousbandAndWife?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "orgnlChildrenFromFamilyHousbandAndWife":
        using (var context = new Eredity())
        {
            var db = new FirstGenerationHousbandAndWife()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond

            };
            context?.ChildrenFromHousbandAndWife?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
    case "originalHousbandAndWifeChildrenFromFamily":
        using (var context = new Eredity())
        {
            var db = new FirstGenerationWifesOfChildrenOfFamily()
            {
                Name = name,
                Surname = surname,
                Parental = parental,
                ParentalBond = parentalbond

            };
            //context.OriginalChildrenFromHousbandAndWife.Add(db);
            context.SaveChangesAsync();
        }
        break;
    case "orgnlChildrenHousbandAndWifeFromOriginal":
        using (var context = new Eredity())
        {
            var children = context?.HousbandAndWifeChildren?.Find(findNumberOfParental);

            var db = new SecondGenerationChildrenOfFamily()
            {
                Name = children?.Name,
                Surname = children?.Surname,
                Parental = children?.Parental,
                ParentalBond = children?.ParentalBond

            };
            context?.Children?.Add(db);
            context?.SaveChangesAsync();
        }
        break;
}


var findcontext = new Eredity();
var find = "";

switch (swtch)
{
    case "supreme":
        find = findcontext?.SupremeEntity?.FindAsync(parental).Result.ToString();
        break;
    case "fatherANDmother":
        find = findcontext?.OriginalFatherAndMother?.FindAsync(parental).Result.ToString();
        break;
    case "childrenOfFatherAndMother":
        find = findcontext?.MotherAndFatherChildren?.FindAsync(parental).Result.ToString();
        break;
    case "wifes":
        find = findcontext?.WifeFromtOtherFamily?.FindAsync(parental).Result.ToString();
        break;
    case "HousbandAndWife":
        find = findcontext?.HousbandAndWife?.FindAsync(parental).Result.ToString();
        break;
    case "orgnlChildrenFromFamilyHousbandAndWife":
        find = findcontext?.HousbandAndWifeChildren?.FindAsync(parental).Result.ToString();
        break;
    case "originalHousbandAndWifeChildrenFromFamily":
        find = findcontext?.ChildrenFromHousbandAndWife?.FindAsync(parental).Result.ToString();
        break;
    case "orgnlChildrenHousbandAndWifeFromOriginal":
        find = findcontext?.Children?.FindAsync(parental).Result.ToString();
        break;
}

Console.WriteLine(find);
