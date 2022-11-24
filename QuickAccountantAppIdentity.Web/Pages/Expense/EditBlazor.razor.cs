using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Expense
{
    public partial class EditBlazor
    {
        [Inject]
        protected IExpensesService ExpenseService { get; set; }

        [Inject]
        protected IExpenseTypeService ExpenseTypeService { get; set; } //** cambiar por income ??

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        public ExpenseRecord ExpenseRecords { get; set; }
        private List<ExpenseType> ExpenseTypes { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ExpenseRecords = await ExpenseService.GetExpenseID(Id);
            ExpenseTypes = await ExpenseTypeService.GetExpenseTypeList();
        }

        private async void SubmitExpense()
        {
            await ExpenseService.UpdateExpenseRecord(ExpenseRecords);

            NavigationManager.NavigateTo("/expenses");
        }


    }
}
