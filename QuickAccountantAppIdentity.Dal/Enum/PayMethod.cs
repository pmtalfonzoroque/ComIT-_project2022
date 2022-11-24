using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAccountantAppIdentity.Dal.Enum
{
    public enum PayMethod :byte
    {
        Visa = 0,
        MasterCard = 1,
        AmericanExpress = 2,
        Debit= 3,
        Cash = 4,
        Cuppon = 5,
        Check = 6,
        Transfer= 7,
        Other = 8 // if other is selected a box for comment should be displayed and the user can mention the Payment Method
    }
}
