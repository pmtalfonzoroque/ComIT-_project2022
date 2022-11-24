using QuickAccountantAppIdentity.web.Services.Interfaces;
using QuickAccountantAppIdentity.Dal.Model;
using Microsoft.AspNetCore.Components;

namespace QuickAccountantAppIdentity.Web.Pages.Income
{
    public partial class CreateIncomeBlazor
    {
        [Inject]
        protected  IIncomeService IncomeService { get; set; }

        [Inject]
        protected IIncomeTypeService IncomeTypeService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public IncomeRecord IncomeRecords { get; set; }

        private List<IncomeType> IncomeTypes { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IncomeRecords = new IncomeRecord();
            IncomeRecords.IncomeTypeID = 1;
            IncomeTypes = await IncomeTypeService.GetIncomeTypeList();
        }

        private async Task SubmitIncome()
        {
            await IncomeService.CreateIncome(IncomeRecords);
            NavigationManager.NavigateTo("/incomes");
        }


    }
}
