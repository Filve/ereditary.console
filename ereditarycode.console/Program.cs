// See https://aka.ms/new-console-template for more information
using ereditarycode.console;

var find = "";
var findDb = "";
var findNumberOfParental = 0;

Console.WriteLine("WRITE IN BLOCK MAIUSCLE 'SKIP' FOR FIND OR PRESS ENTER");

if (Console.ReadLine() != "SKIP")
{
    Console.WriteLine("  \r\n" +
        "before COPY AND PAST OR WRITE ONE of THESE for add in the db what you need OR press enter to skip:\r\n" +
        "-START TO COPY OR WRITE-\r\n" +
        "SupremeEntities\r\n" +
        "FaterAndMother\r\n" +
        "FatherAndMotherChildren\r\n" +
        "HousbandAndWifeOfFamily\r\n" +
        "WifesOfChildrenOfFatherAndMother\r\n" +
        "FirstGenerationChildrenOfFamily\r\n" +
        "FirstGenerationHousbandAndWife\r\n" +
        "FirstGenerationWifesOfChildrenOfFamily\r\n" +
        "SecondGenerationChildrenOfFamily\r\n" +
        "-END TO COPY OR WRITE-");

    var swtch = Console.ReadLine();
    findDb = swtch;

    Console.WriteLine("Write name of father OR press enter to skip");
    var name = Console.ReadLine();

    Console.WriteLine("Write surname of father OR press enter to skip");
    var surname = Console.ReadLine();

    Console.WriteLine("Write complete name of mother OR press enter to skip");
    var namemother = Console.ReadLine();

    Console.WriteLine("Write name PARENTAL BOND like code in string for each family the same BOND, remember it OR press enter to skip");
    var parentalbond = Console.ReadLine();

    Console.WriteLine("Write put a number AND REMEMBER IT, just number THE PARENTAL CODE AND SKIP THE ZERO '0' OR press enter to skip");
    var parentalcode = Console.Read();
    findNumberOfParental = parentalcode;

    switch (swtch)
    {
        case "SupremeEntities":
            using (var context = new Eredity())
            {
                var db = new SupremeEntites()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,

                };

                var searchIfExist = context?.SupremeEntities?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context.SupremeEntities.Add(db);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist");
            }
            break;
        case "FaterAndMother":
            using (var context = new Eredity())
            {
                var db = new FaterAndMother()
                {
                    FatherCompleteName = name + " " + surname,
                    MotherCompleteName = namemother,
                    ParentalBond = parentalbond,
                    ParentalCode = parentalcode
                };

                var searchIfExist = context?.FaterAndMother?.FindAsync(parentalcode)?.Result?.ParentalCode;


                if (searchIfExist == null)
                {
                    context?.FaterAndMother?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");
            }
            break;
        case "FatherAndMotherChildren":
            using (var context = new Eredity())
            {
                var db = new FatherAndMotherChildren()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };
                var searchIfExist = context?.FatherAndMotherChildren?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.FatherAndMotherChildren?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");

            }
            break;
        case "HousbandAndWifeOfFamily":
            using (var context = new Eredity())
            {
                var db = new HousbandAndWifeOfFamily()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };

                var searchIfExist = context?.HousbandAndWifeOfFamily?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.HousbandAndWifeOfFamily?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");

            }
            break;
        case "WifesOfChildrenOfFatherAndMother":
            using (var context = new Eredity())
            {
                var db = new WifesOfChildrenOfFatherAndMother()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };

                var searchIfExist = context?.WifesOfChildrenOfFatherAndMother?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.WifesOfChildrenOfFatherAndMother?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");

            }
            break;
        case "FirstGenerationChildrenOfFamily":
            using (var context = new Eredity())
            {
                var db = new FirstGenerationChildrenOfFamily()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };

                var searchIfExist = context?.FirstGenerationChildrenOfFamily?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.FirstGenerationChildrenOfFamily?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");

            }
            break;
        case "FirstGenerationHousbandAndWife":
            using (var context = new Eredity())
            {
                var db = new FirstGenerationHousbandAndWife()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };
                var searchIfExist = context?.FirstGenerationHousbandAndWife?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.FirstGenerationHousbandAndWife?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");
            }
            break;
        case "FirstGenerationWifesOfChildrenOfFamily":
            using (var context = new Eredity())
            {
                var db = new FirstGenerationWifesOfChildrenOfFamily()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond

                };

                var searchIfExist = context?.FirstGenerationWifesOfChildrenOfFamily?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.FirstGenerationWifesOfChildrenOfFamily?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");
            }
            break;
        case "SecondGenerationChildrenOfFamily":
            using (var context = new Eredity())
            {
                var children = context?.FirstGenerationWifesOfChildrenOfFamily?.Find(parentalcode);

                var db = new SecondGenerationChildrenOfFamily()
                {
                    Name = children.Name,
                    Surname = children.Surname,
                    ParentalCode = children.ParentalCode,
                    ParentalBond = children.ParentalBond

                };

                var searchIfExist = context?.SecondGenerationChildrenOfFamily?.FindAsync(parentalcode)?.Result?.ParentalCode;

                if (searchIfExist == null)
                {
                    context?.SecondGenerationChildrenOfFamily?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");
            }
            break;
    }
}
else
{
    Console.WriteLine("\r\n" +
    "SEARCH THE DB, PUT ONE OF THIS OR PRESS ENTER TO SKIP:\r\n" +
    "-START TO COPY OR WRITE-\r\n" +
    "SupremeEntities\r\n" +
    "FaterAndMother\r\n" +
    "FatherAndMotherChildren\r\n" +
    "HousbandAndWifeOfFamily\r\n" +
    "WifesOfChildrenOfFatherAndMother\r\n" +
    "FirstGenerationChildrenOfFamily\r\n" +
    "FirstGenerationHousbandAndWife\r\n" +
    "FirstGenerationWifesOfChildrenOfFamily\r\n" +
    "SecondGenerationChildrenOfFamily" +
    "-END TO COPY OR WRITE-");

    findDb = Console.ReadLine();
    find = "";


    Console.WriteLine("PUT THE PARENTAL CODE THAT YOU NEED TO SEARCH:");
    findNumberOfParental = Console.Read();
}


var findcontext = new Eredity();


switch (findDb)
{
    case "SupremeEntities":
        find = findcontext?.SupremeEntities.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "FaterAndMother":
        find = findcontext?.FaterAndMother?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "FatherAndMotherChildren":
        find = findcontext?.FatherAndMotherChildren?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "WifesOfChildrenOfFatherAndMother":
        find = findcontext?.WifesOfChildrenOfFatherAndMother?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "HousbandAndWifeOfFamily":
        find = findcontext?.HousbandAndWifeOfFamily?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "FirstGenerationWifesOfChildrenOfFamily":
        find = findcontext?.FirstGenerationWifesOfChildrenOfFamily?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "FirstGenerationChildrenOfFamily":
        find = findcontext?.FirstGenerationChildrenOfFamily?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "FirstGenerationHousbandAndWife":
        find = findcontext?.FirstGenerationHousbandAndWife?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
    case "SecondGenerationChildrenOfFamily":
        find = findcontext?.SecondGenerationChildrenOfFamily?.FindAsync(findNumberOfParental).Result.ParentalCode.ToString();
        break;
}

Console.WriteLine(find);
