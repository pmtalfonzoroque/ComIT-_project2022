using QuickAccountantAppIdentity.Dal.Model;

namespace QuickAccountantAppIdentity.web.Services.Interfaces
{
    public interface IIncomeTypeService
    {
        public Task<List<IncomeType>> GetIncomeTypeList();

    }
}