// See https://aka.ms/new-console-template for more information
using ereditarycode.console;


object find;
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

    Console.WriteLine("Write a number, just number it will be modify OR press enter to skip");
    var parentalcode = Console.Read();
    findNumberOfParental = parentalcode;

    var individualCode = 0;

    switch (swtch)
    {
        case "SupremeEntities":
            using (var context = new DataContext())
            {

                var db = new SupremeEntities()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond
                };

                context?.SupremeEntities.Add(db);
                context?.SaveChanges();


                var familySearch = context?.FamilyMembers?.Find(db.IndividualCode);

                IncrementalAndCheckFamilyMembers.AddSupremeEntities(parentalcode, name, surname, parentalbond);


            }
            break;
        case "FaterAndMother":
            Console.WriteLine("Write name of mother OR press enter to skip");
            var namemother = Console.ReadLine();
            Console.WriteLine("Write surname of mother OR press enter to skip");
            var surnamemother = Console.ReadLine();
            using (var context = new DataContext())
            {

                var searchIfExist = context?.SupremeEntities?.FindAsync(parentalcode)?.Result?.ParentalCode;
                var db = new FaterAndMotherOriginally()
                {
                    FatherCompleteName = name + " " + surname,
                    MotherCompleteName = namemother + " " + surnamemother,
                    ParentalBond = parentalbond,
                    ParentalCode = parentalcode,
                    IndividualCode = IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalcode)

                };

                if (searchIfExist == null)
                {
                    context?.FaterAndMotherOriginally?.Add(db);
                    context?.SaveChangesAsync();
                }
                else
                    Console.WriteLine("Already Exist Parental Code");
                searchIfExist = context?.FaterAndMotherActual?.FindAsync(parentalcode).Result?.Id;
                var familyfatherSearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;
                AddFamilyMembersInDb(parentalcode, name, surname, parentalbond);
                familyfatherSearch = context?.FamilyMembers?.FindAsync(parentalcode)?.Result.IndividualCode;
                var familymotherdb = new FamilyMembers()
                {
                    Name = namemother,
                    Surname = surnamemother,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = AutoIncrementalGuild(familyfatherSearch.Value)

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
            using (var context = new DataContext())
            {
                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.ParentalCode;
                var db = new Children()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(searchIfExist.Value)
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
            using (var context = new DataContext())
            {
                var searchIfExist = context?.FamilyMembers?.FindAsync(parentalcode)?.Result?.IndividualCode;
                var db = new HousbandAndWifeOfFamily()
                {
                    Name = name,
                    Surname = surname,
                    ParentalCode = parentalcode,
                    ParentalBond = parentalbond,
                    IndividualCode = IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(searchIfExist.Value)

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


var findcontext = new DataContext();


switch (findDb)
{
    case "SupremeEntities":
        var context = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result;
        find = new SupremeEntities()
        {
            Name = context.Name,
            Surname = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.Surname,
            ParentalCode = findcontext.SupremeEntities.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.SupremeEntities.FindAsync().Result.CreationDate,
            ParentalBond = findcontext.SupremeEntities.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
    case "FaterAndMother":
        find = new FaterAndMotherOriginally()
        {
            FatherCompleteName = findcontext.FaterAndMotherOriginally.FindAsync(findNumberOfParental).Result.FatherCompleteName,
            MotherCompleteName = findcontext.FaterAndMotherOriginally.FindAsync(findNumberOfParental).Result.MotherCompleteName,
            ParentalCode = findcontext.FaterAndMotherOriginally.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.FaterAndMotherOriginally.FindAsync(findNumberOfParental).Result.CreationDate,
            ParentalBond = findcontext.FaterAndMotherOriginally.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
    case "Children":
        find = new Children()
        {
            Name = findcontext.Children.FindAsync(findNumberOfParental).Result.Name,
            Surname = findcontext.Children.FindAsync(findNumberOfParental).Result.Surname,
            ParentalCode = findcontext.Children.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.Children.FindAsync(findNumberOfParental).Result.CreationDate,
            ParentalBond = findcontext.Children.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
    case "Wifes":
        find = new Wifes()
        {
            Name = findcontext.Wifes.FindAsync(findNumberOfParental).Result.Name,
            Surname = findcontext.Wifes.FindAsync(findNumberOfParental).Result.Surname,
            ParentalCode = findcontext.Wifes.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.Wifes.FindAsync(findNumberOfParental).Result.CreationDate,
            ParentalBond = findcontext.Wifes.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
    case "HousbandAndWifeOfFamily":
        find = new HousbandAndWifeOfFamily()
        {
            Name = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.Name,
            Surname = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.Surname,
            ParentalCode = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.HousbandAndWifeOfFamily.FindAsync(findNumberOfParental).Result.CreationDate,
            ParentalBond = findcontext.HousbandAndWifeOfFamily.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
    case "FamilyMembers":
        find = new FamilyMember()
        {
            Name = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.Name,
            Surname = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.Surname,
            ParentalCode = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.ParentalCode,
            CreationDate = findcontext.FamilyMembers.FindAsync(findNumberOfParental).Result.CreationDate,
            ParentalBond = findcontext.FamilyMembers.FindAsync(findcontext).Result.ParentalBond,
        };
        Console.WriteLine(find);
        break;
}

