using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using QuickAccountantAppIdentity.Web.Shared;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Income // this is the backen that feed the other  razor
{
    public partial class ListIncomeBlazor // partial is the same class definded in the same file
    {
        [Inject]
        protected IIncomeService IncomeService { get; set; } //ExpenseService will be an instance of the Service that we are delcaring
        private List<IncomeRecord> IncomeRecords { get; set; }

        private IncomeRecord? income;

        private ConfirmationModal? myConfirmationModal;

        protected override async Task OnInitializedAsync()
        {
            IncomeRecords = await IncomeService.GetIncomeList(); // when This page intizialise it is going to run the GetExpenseList
        }

        public async Task DeleteIncome(int incomeId) // this is the name of the task
        {

            income = await IncomeService.GetIncomeID(incomeId);
            if (income != null)
            {
                //await IncomeService.DeleteIncomeRecord(income); // DeleteExpenseRecord is the name of the method
                await myConfirmationModal.Show();
                //IncomeRecords.RemoveAll(x => x.Id == incomeId);
            }
        }

        private async Task DeleteConfirmedClick()
        {
            await IncomeService.DeleteIncomeRecord(income);
            IncomeRecords.RemoveAll(x => x.Id == income.Id);
        }

    }
}
