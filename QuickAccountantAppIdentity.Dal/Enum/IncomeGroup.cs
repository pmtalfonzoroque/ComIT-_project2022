using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAccountantAppIdentity.Dal.Enum
{
    public enum IncomeGroup : byte
    {
        Earned = 0,//includes wages (per hour), salary (fixed amount), tips and commissions
        Passive = 1,//Passive or unearned income could come from rental properties, royalties and limited partnerships
        Profit =2,//made from a business activity.
        Portfolio = 3//Portfolio or investment income includes interest, dividends and capital gains on investments
    }
}
