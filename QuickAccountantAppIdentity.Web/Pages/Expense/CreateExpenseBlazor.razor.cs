using QuickAccountantAppIdentity.web.Services.Interfaces;
using QuickAccountantAppIdentity.Dal.Model;
using Microsoft.AspNetCore.Components;

namespace QuickAccountantAppIdentity.Web.Pages.Expense
{
    public partial class CreateExpenseBlazor
    {
        [Inject]
        protected  IExpensesService ExpensesService { get; set; }

        [Inject]
        protected IExpenseTypeService ExpenseTypeService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ExpenseRecord ExpenseRecords { get; set; }

        private List<ExpenseType> ExpenseTypes { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ExpenseRecords = new ExpenseRecord();
            ExpenseRecords.ExpenseTypeID = 1;
            ExpenseTypes = await ExpenseTypeService.GetExpenseTypeList();
        }

        private async Task SubmitExpense()
        {
            await ExpensesService.CreateExpense(ExpenseRecords);
            NavigationManager.NavigateTo("/expenses");
        }


    }
}
