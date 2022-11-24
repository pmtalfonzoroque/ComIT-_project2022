using QuickAccountantAppIdentity.Dal.Context;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace QuickAccountantAppIdentity.web.Services
{
    public class ExpenseTypeService : IExpenseTypeService
    {

        private readonly ApplicationDbContext _DbContext; // we always need DB Context

        public ExpenseTypeService(ApplicationDbContext context)
        {
            _DbContext = context;
        } 

        public async Task<List<ExpenseType>> GetExpenseTypeList()
        {
            List<ExpenseType> expenseTypeList = new();

            expenseTypeList = await _DbContext.ExpenseTypes.OrderBy(p => p.DisplayOrder).ToListAsync(); // This is equivalent to SQL as = select *
                                                                                                        // from ExpenseType Order by DisplayOrder asc
            return expenseTypeList;
        }
    }
}
