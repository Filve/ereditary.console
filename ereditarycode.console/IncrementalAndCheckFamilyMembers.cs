using Microsoft.Extensions.Logging;

namespace ereditarycode.console
{
    public class IncrementalAndCheckFamilyMembers
    {
        public DataContext data;
        public IncrementalAndCheckFamilyMembers(DataContext db)
        {
            data = db;
        }

        public static int AutoIncrementalGuild(int? idToCheck)
        {
            var id = data?.SupremeEntities.Find(idToCheck)?.Id;
            int numberToIncrement = id != null && id == 0 ? 0 : id.Value;
            if (numberToIncrement != 0)
            {
                int number = Interlocked.Increment(ref numberToIncrement);
                var check = data?.SupremeEntities?.Find(number).IndividualCode;
                if (check != 0 && check != null)
                {
                    return number;
                }
            }
            return 0;
        }

        public static bool CheckParentalCode(int parentalCode)
        {
            var check = data?.SupremeEntities?.Find(parentalCode);
            return check?.ParentalCode != 0 && check?.ParentalCode != null || check?.ParentalCode == parentalCode ? true : false;
        }

        public static bool CheckIndividualCode(int individualCode)
        {
            var check = data.SupremeEntities.FindAsync(individualCode).Result;
            return check.IndividualCode != 0 || check.IndividualCode == individualCode ? true : false;
        }

        public static bool? CheckParentalCodeFamily(int parentalCode)
        {
            var check = data.SupremeEntities.FindAsync(parentalCode).Result;

            return check.ParentalCodeFamily != 0 || check.ParentalCodeFamily == parentalCode ? true : false;
        }

        public static FamilyMember AddFamilyMemberInDb(FamilyMembers familyMember, int parentalCode)
        {
            var searchIfExist = data?.FamilyMember?.FindAsync(parentalCode)?.Result?.IndividualCode;
            var familydb = new FamilyMember()
            {
                Name = familyMember.Name,
                Surname = familyMember.Surname,
                ParentalCode = familyMember.ParentalCode,
                ParentalBond = familyMember.ParentalBond
            };
            if (searchIfExist == null)
            {
                data.FamilyMember.Add(familydb);
                data.SaveChanges();
            }
            return familydb;
        }

        public static FamilyMembers AddFamilyMembersInDb(int parentalCode, string name, string surname, string parentalBond)
        {
            var searchIfExist = data?.FamilyMembers?.FindAsync(parentalCode)?.Result?.IndividualCode;
            var familydb = new FamilyMembers()
            {
                Name = name,
                Surname = surname,
                ParentalCode = parentalCode,
                ParentalBond = parentalBond,
                IndividualCode = AutoIncrementalGuild(searchIfExist.Value)

            };
            if (searchIfExist == null)
            {
                data.FamilyMembers.Add(familydb);
                data.SaveChanges();
            }


            return familydb;
        }

        public SupremeEntities AddSupremeEntities(int parentalCode, string name, string surname, string parentalBond)
        {
            var searchIfExist = data?.FamilyMembers?.FindAsync(parentalCode)?.Result?.IndividualCode;
            var familydb = new SupremeEntities()
            {
                Name = name,
                Surname = surname,
                ParentalCode = parentalCode,
                ParentalBond = parentalBond,
                IndividualCode = AutoIncrementalGuild(searchIfExist.Value)

            };
            if (searchIfExist == null)
            {
                data.SupremeEntities.Add(familydb);
                data.SaveChanges();
            }


            return familydb;
        }

        public List<FamilyMembers> AllFamilyMembersInDb(List<FamilyMembers>? familyMembers)
        {
            var list = data.FamilyMembers.ToList();
            foreach (var i in list)
            {
                familyMembers?.Add(i);
            }
            return familyMembers;
        }

        public List<FamilyMembers> CheckAllFamilyParentalCode(int parentalCode)
        {
            var result = data.FamilyMembers.Where(x => x.ParentalCode == parentalCode);
            return result.ToList();
        }
    }
}
