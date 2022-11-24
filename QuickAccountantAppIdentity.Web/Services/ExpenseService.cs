using Microsoft.EntityFrameworkCore;
using QuickAccountantAppIdentity.Dal.Context;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;

namespace QuickAccountantAppIdentity.web.Services
{
    // this are my bussiness layers related to ExpensesRecords
    // this Class is created as part of the Backend, and it is created after the "I**" classes to implement its methods
    public class ExpenseService : IExpensesService  
    {
        private readonly ApplicationDbContext _DbContext;

        public ExpenseService(ApplicationDbContext DbContext) // this is a method
        {

            _DbContext = DbContext; // DbContext is being injected from outside
        }

        public async Task<List<ExpenseRecord>> GetExpenseList()// it is a method to get the list of expenses
                                                               // / Async allow us ot run different methods at the same time
        {
            List<ExpenseRecord> returnList = new();
            returnList = await _DbContext.ExpenseRecords
                                  .Include(p => p.ExpenseRecordType)
                                  .ToListAsync();

            await Task.Delay(1000);

            return returnList;
        }

        public async Task<ExpenseRecord> GetExpenseID(int id)
        {
            ExpenseRecord? expenseRecord = null; // this is another way to do it in steps

            expenseRecord = await _DbContext.ExpenseRecords  // expenseRecord is an object
                .Include(x => x.ExpenseRecordType)
                .FirstOrDefaultAsync(x => x.Id == id);
            return expenseRecord;

            //return await _DbContext.ExpenseRecords
            //    .Include(x => x.ExpenseRecordType)
            //    .FirstOrDefaultAsync(x => x.Id == id); // this is like write in SQL = SELECT * from ExpenseRecord as ER
            // inner join ExpenseRecordType as ERT on ER.ExpenseRecordType = ERT.Id
            // WHERE
            // ER.Id= "something"
        }

        public async Task<ExpenseRecord> CreateExpense(ExpenseRecord expense) // a method to create the expenses and it create the object named expense 
        { 
            _DbContext. ExpenseRecords.Add(expense); //it creates and return the expense with updated ID
            await _DbContext.SaveChangesAsync();
            return expense;

        }

        public async Task UpdateExpenseRecord(ExpenseRecord expense)
        {
            _DbContext.ExpenseRecords.Update (expense);
            await _DbContext.SaveChangesAsync(); // need to save the changes
        }

        public async Task DeleteExpenseRecord(ExpenseRecord expense)
        {
            _DbContext.ExpenseRecords.Remove(expense); // delete from the database
            await _DbContext.SaveChangesAsync(); // remove the row from the list
        }
    }
}
