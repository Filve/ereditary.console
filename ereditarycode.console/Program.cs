// See https://aka.ms/new-console-template for more information
using ereditarycode.console;

var find = new EredityModel();
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
        "Children\r\n" +
        "HousbandAndWifeOfFamily\r\n" +
        "Wifes\r\n" +
        "-END TO COPY OR WRITE-");

    var swtch = Console.ReadLine();
    findDb = swtch;

    Console.WriteLine("Write name OR press enter to skip");
    var name = Console.ReadLine();

    Console.WriteLine("Write surname OR press enter to skip");
    var surname = Console.ReadLine();

    Console.WriteLine("Write name PARENTAL BOND like code in string for each family the same BOND, it will modify OR press enter to skip");
    var parentalbond = Console.ReadLine();

    Console.WriteLine("Write put a number AND REMEMBER IT, just number it will be modify OR press enter to skip");
    var parentalcode = Console.Read();
    findNumberOfParental = parentalcode;

    switch (swtch)
    {
        case "SupremeEntities":
            using (var context = new Eredity())
            {

                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;
                var db = new SupremeEntities()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(parentalcode)

                };


                if (searchIfExist == null)
                {
                    context.SupremeEntities.Add(db);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist Parental Code");


                searchIfExist = context?.SupremeEntities?.FindAsync(parentalcode)?.Result?.IndividualCode;
                Console.WriteLine(searchIfExist.Value);
                var familySearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;

                var familydb = new FamilyMembers()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = searchIfExist.Value

                };


                if (searchIfExist == null)
                {
                    context.FamilyMembers.Add(familydb);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist in Family Member");

            }
            break;
        case "FaterAndMother":
            Console.WriteLine("Write name of mother OR press enter to skip");
            var namemother = Console.ReadLine();
            Console.WriteLine("Write surname of mother OR press enter to skip");
            var surnamemother = Console.ReadLine();
            using (var context = new Eredity())
            {

                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.ParentalCode;
                var db = new FaterAndMother()
                {
                    FatherCompleteName = name + " " + surname,
                    MotherCompleteName = namemother + " " + surnamemother,
                    ParentalBond = parentalbond,
                    ParentalCode = parentalcode,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(parentalcode)

                };

                if (searchIfExist == null)
                {
                    context?.FaterAndMother?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist Parental Code");
                searchIfExist = context?.FaterAndMother?.FindAsync(parentalcode).Result?.Id;
                var familyfatherSearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;
                var familydb = new FamilyMembers()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(searchIfExist.Value)

                };
                if (familyfatherSearch == null)
                {
                    context.FamilyMembers.Add(familydb);
                    context.SaveChanges();
                }
                familyfatherSearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result.IndividualCode;
                var familymotherdb = new FamilyMembers()
                {
                    Name = namemother,
                    Surname = surnamemother,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(familyfatherSearch.Value)

                };

                var familymotherSearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;

                if (familymotherSearch == null)
                {
                    context.FamilyMembers.Add(familymotherdb);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist in Family Member");

            };

            break;
        case "Children":
            using (var context = new Eredity())
            {
                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.ParentalCode;
                var db = new Children()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(searchIfExist.Value)
                };

                if (searchIfExist == null)
                {
                    context?.Children?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist");

                searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.ParentalCode;

                var familydb = new FamilyMembers()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = searchIfExist.Value

                };


                if (searchIfExist == null)
                {
                    context.FamilyMembers.Add(familydb);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist in Family Member");



            }
            break;
        case "HousbandAndWifeOfFamily":
            using (var context = new Eredity())
            {
                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;
                var db = new HousbandAndWifeOfFamily()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild.AutoIncremental(searchIfExist.Value)

                };


                if (searchIfExist == null)
                {
                    context?.HousbandAndWifeOfFamily?.Add(db);
                    context?.SaveChangesAsync();
                    Console.WriteLine(searchIfExist.Value);
                }
                else
                    Console.WriteLine("Already Exist");

                searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;

                var familydb = new FamilyMembers()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = searchIfExist.Value

                };


                if (searchIfExist == null)
                {
                    context.FamilyMembers.Add(familydb);
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Already Exist in Family Member");


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
    "Children\r\n" +
    "HousbandAndWifeOfFamily\r\n" +
    "Wifes\r\n" +
    "-END TO COPY OR WRITE-");

    findDb = Console.ReadLine();
    Console.WriteLine("PUT THE PARENTAL CODE THAT YOU NEED TO SEARCH:");
    findNumberOfParental = Console.Read();
}


var findcontext = new Eredity();


switch (findDb)
{
    case "SupremeEntities":
        find = new EredityModel()
        {
            SupremeEntity = new SupremeEntities()
            {
                Name = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.Name,
                Surname = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.Surname,
                ParentalCode = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.SupremeEntities.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.SupremeEntity);
        break;
    case "FaterAndMother":
        find = new EredityModel()
        {
            FatherAndMother = new FaterAndMother()
            {
                FatherCompleteName = findcontext.FaterAndMother.FindAsync(findNumberOfParental).Result.FatherCompleteName,
                MotherCompleteName = findcontext.FaterAndMother.FindAsync(findNumberOfParental).Result.MotherCompleteName,
                ParentalCode = findcontext.FaterAndMother.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.FaterAndMother.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.FaterAndMother.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.FatherAndMother);
        break;
    case "Children":
        find = new EredityModel()
        {
            Children = new Children()
            {
                Name = findcontext.Children.FindAsync(findNumberOfParental).Result.Name,
                Surname = findcontext.Children.FindAsync(findNumberOfParental).Result.Surname,
                ParentalCode = findcontext.Children.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.Children.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.Children.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.Children);
        break;
    case "Wifes":
        find = new EredityModel()
        {
            Wifes = new Wifes()
            {
                Name = findcontext.Wifes.FindAsync(findNumberOfParental).Result.Name,
                Surname = findcontext.Wifes.FindAsync(findNumberOfParental).Result.Surname,
                ParentalCode = findcontext.Wifes.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.Wifes.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.Wifes.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.Wifes);
        break;
    case "HousbandAndWifeOfFamily":
        find = new EredityModel()
        {
            HousbandAndWifeOfFamily = new HousbandAndWifeOfFamily()
            {
                Name = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.Name,
                Surname = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.Surname,
                ParentalCode = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.HousbandAndWifeOfFamily.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.HousbandAndWifeOfFamily);
        break;
    case "FamilyMembers":
        find = new EredityModel()
        {
            FamilyMembers = new FamilyMember()
            {
                Name = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.Name,
                Surname = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.Surname,
                ParentalCode = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.ParentalCode,
                CreationDate = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.CreationDate,
                ParentalBond = findcontext.FamilyMembers.FindAsync(findcontext).Result.ParentalBond,
            },
        };
        Console.WriteLine(find.FamilyMembers);
        break;
}

