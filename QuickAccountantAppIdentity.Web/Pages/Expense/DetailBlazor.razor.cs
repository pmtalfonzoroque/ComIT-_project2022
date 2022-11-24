using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Expense
{
    public partial class DetailBlazor
    {
        [Inject]
        protected IExpensesService ExpenseService { get; set; }
        [Parameter]
        public int Id { get; set; }

        public ExpenseRecord ExpenseRecord { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ExpenseRecord = await ExpenseService.GetExpenseID(Id);
        }

    }
}
