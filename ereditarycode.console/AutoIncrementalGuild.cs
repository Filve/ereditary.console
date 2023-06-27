using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ereditarycode.console;

namespace ereditarycode.console
{
    public static class AutoIncrementalGuild
    {

        public static int AutoIncremental(int contextId)
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
    }
}
