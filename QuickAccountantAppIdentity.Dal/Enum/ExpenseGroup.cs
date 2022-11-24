using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAccountantAppIdentity.Dal.Enum
{
    public enum ExpenseGroup : byte
    {
        Variable = 0, //  Expenses that vary from month to month (electriticy, gas, groceries, clothing).
        Fixed = 1, //  Expenses that remain the same from month to month(rent, cable bill, car payment)
        Intermittent = 2,// Expenses that occur at various times throughout
                         // the year and tend to be in large amounts(tuition payment, car repairs)
        Discretionary = 3 // (non-essential) Expenses for things we don't need (eating out, gifts, snacks)
    }
}
