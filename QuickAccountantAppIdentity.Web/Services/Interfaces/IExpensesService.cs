using QuickAccountantAppIdentity.Dal.Model;

namespace QuickAccountantAppIdentity.web.Services.Interfaces
{
    public interface IExpensesService // this is the behavior we expect to get, it is done before the pages as part of the back end
    {
        public Task<List <ExpenseRecord>> GetExpenseList();

        public Task<ExpenseRecord> GetExpenseID( int id);
        public Task<ExpenseRecord> CreateExpense(ExpenseRecord expense);
        public Task UpdateExpenseRecord(ExpenseRecord expense);

        public Task DeleteExpenseRecord(ExpenseRecord expense);
    }
}
