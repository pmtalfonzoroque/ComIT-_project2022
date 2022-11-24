using QuickAccountantAppIdentity.Dal.Context;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace QuickAccountantAppIdentity.web.Services
{
    public class IncomeTypeService : IIncomeTypeService
    {

        private readonly ApplicationDbContext _DbContext; // we always need DB Context

        public IncomeTypeService(ApplicationDbContext context)
        {
            _DbContext = context;
        }

        public async Task<List<IncomeType>> GetIncomeTypeList()
        {
            List<IncomeType> incomeTypeList = new();

            incomeTypeList = await _DbContext.IncomeTypes.OrderBy(p => p.DisplayOrder).ToListAsync(); // This is equivalent to SQL as = select *
                                                                                                        // from ExpenseType Order by DisplayOrder asc
            return incomeTypeList;
        }
    }
}