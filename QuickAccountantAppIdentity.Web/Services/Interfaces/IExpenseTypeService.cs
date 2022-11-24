using QuickAccountantAppIdentity.Dal.Model;

namespace QuickAccountantAppIdentity.web.Services.Interfaces
{
    public interface IExpenseTypeService
    {
        public Task<List<ExpenseType>> GetExpenseTypeList();

    }
}
