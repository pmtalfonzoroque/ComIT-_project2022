using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using QuickAccountantAppIdentity.Web.Shared;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Expense // this is the backen that feed the other  razor
{
    public partial class ListExpenseBlazor // partial is the same class definded in the same file
    {
        [Inject]
        protected IExpensesService ExpenseService { get; set; } //ExpenseService will be an instance of the Service that we are delcaring
        private List<ExpenseRecord> ExpenseRecords { get; set; }

        private ExpenseRecord? expense;

        private ConfirmationModal? myConfirmationModal;

        protected override async Task OnInitializedAsync()
        {
            ExpenseRecords = await ExpenseService.GetExpenseList(); // when This page intizialise it is going to run the GetExpenseList
        }

        public async Task DeleteExpense(int expenseId) // this is the name of the task
        {

            //var expense = await ExpenseService.GetExpenseID(expenseId);
           expense = await ExpenseService.GetExpenseID(expenseId);
            if (expense != null)
            {
                //await ExpenseService.DeleteExpenseRecord(expense); // DeleteExpenseRecord is the name of the method
                await myConfirmationModal.Show();
                //ExpenseRecords.RemoveAll(x => x.Id == expenseId);
            }
        }

        private async Task DeleteConfirmedClick()
        {
            await ExpenseService.DeleteExpenseRecord(expense);
            ExpenseRecords.RemoveAll(x => x.Id == expense.Id);
        }

    }
}
