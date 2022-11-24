using QuickAccountantAppIdentity.Dal.Model;

namespace QuickAccountantAppIdentity.web.Services.Interfaces
{
    public interface IIncomeService // this is the behavior we expect to get, it is done before the pages as part of the back end
    {
        public Task<List<IncomeRecord>> GetIncomeList();

        public Task<IncomeRecord> GetIncomeID(int id);
        public Task<IncomeRecord> CreateIncome(IncomeRecord income);
        public Task UpdateIncomeRecord(IncomeRecord income);

        public Task DeleteIncomeRecord(IncomeRecord income);
    }
}
