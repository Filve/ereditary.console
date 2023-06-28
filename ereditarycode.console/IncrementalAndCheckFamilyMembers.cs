namespace ereditarycode.console
{
    public static class IncrementalAndCheckFamilyMembers
    {

        public static int AutoIncrementalGuild(int contextId)
        {
            var context = new Eredity();
            var id = context?.FamilyMembers?.FindAsync(contextId).Result?.Id;
            var numberToIncrement = id.Value;
            return Interlocked.Increment(ref numberToIncrement);
        }

        public static FamilyMembers? CheckParentalCodeFamily(int parentalcode)
        {
            var context = new Eredity();
            var check = context.FamilyMembers.FindAsync(parentalcode).Result;

            return check;
        }

        public static FamilyMember AddFamilyMemberInDb(FamilyMembers familyMember, int parentalCode)
        {
            var context = new Eredity();
            var searchIfExist = context?.FamilyMember?.FindAsync(parentalCode)?.Result?.IndividualCode;
            var familydb = new FamilyMember()
            {
                Name = familyMember.Name,
                Surname = familyMember.Surname,
                ParentalCode = familyMember.ParentalCode,
                ParentalBond = familyMember.ParentalBond,
                IndividualCode = AutoIncrementalGuild(searchIfExist.Value)

            };
            if (searchIfExist == null)
            {
                context.FamilyMember.Add(familydb);
                context.SaveChanges();
            }
            return familydb;
        }

        public static FamilyMembers AddFamilyMembersInDb(int parentalCode, string name, string surname, string parentalBond)
        {
            var context = new Eredity();
            var searchIfExist = context?.FamilyMembers?.FindAsync(parentalCode)?.Result?.IndividualCode;
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
                context.FamilyMembers.Add(familydb);
                context.SaveChanges();
            }


            return familydb;
        }

        public static List<FamilyMembers> AllFamilyMembersInDb(List<FamilyMembers>? familyMembers)
        {
            var context = new Eredity();
            var list = context.FamilyMembers.ToList();
            foreach (var i in list)
            {
                familyMembers?.Add(i);
            }
            return familyMembers;
        }

        public static List<FamilyMembers> CheckAllFamilyParentalCode(int parentalCode)
        {
            var context = new Eredity();
            var result = context.FamilyMembers.Where(x => x.ParentalCode == parentalCode);
            return result.ToList();
        }
    }
}
