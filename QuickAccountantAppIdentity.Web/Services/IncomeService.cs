using Microsoft.EntityFrameworkCore;
using QuickAccountantAppIdentity.Dal.Context;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;

namespace QuickAccountantAppIdentity.web.Services
{
    // this are my bussiness layers related to ExpensesRecords
    // this Class is created as part of the Backend, and it is created after the "I**" classes to implement its methods
    public class IncomeService : IIncomeService
    {
        private readonly ApplicationDbContext _DbContext;

        public IncomeService(ApplicationDbContext DbContext) // this is a method
        {

            _DbContext = DbContext; // DbContext is being injected from outside
        }

        public async Task<List<IncomeRecord>> GetIncomeList()// it is a method to get the list of expenses
                                                               // / Async allow us ot run different methods at the same time
        {
            List<IncomeRecord> returnList = new();
            returnList = await _DbContext.IncomeRecords
                                  .Include(p => p.IncomeRecordType)
                                  .ToListAsync();

            await Task.Delay(1000);

            return returnList;
        }

        public async Task<IncomeRecord> GetIncomeID(int id)
        {
            IncomeRecord? incomeRecord = null; // this is another way to do it in steps

            incomeRecord = await _DbContext.IncomeRecords  // expenseRecord is an object
                .Include(x => x.IncomeRecordType)
                .FirstOrDefaultAsync(x => x.Id == id);
            return incomeRecord;

            //return await _DbContext.ExpenseRecords
            //    .Include(x => x.ExpenseRecordType)
            //    .FirstOrDefaultAsync(x => x.Id == id); // this is like write in SQL = SELECT * from ExpenseRecord as ER
            // inner join ExpenseRecordType as ERT on ER.ExpenseRecordType = ERT.Id
            // WHERE
            // ER.Id= "something"
        }

        public async Task<IncomeRecord> CreateIncome(IncomeRecord income) // a method to create the expenses and it create the object named expense 
        {
            _DbContext.IncomeRecords.Add(income); //it creates and return the expense with updated ID
            await _DbContext.SaveChangesAsync();
            return income;

        }

        public async Task UpdateIncomeRecord(IncomeRecord income)
        {
            _DbContext.IncomeRecords.Update(income);
            await _DbContext.SaveChangesAsync(); // need to save the changes
        }

        public async Task DeleteIncomeRecord(IncomeRecord income)
        {
            _DbContext.IncomeRecords.Remove(income); // delete from the database
            await _DbContext.SaveChangesAsync(); // remove the row from the list
        }
    }
}