using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Income
{
    public partial class EditBlazor
    {
        [Inject]
        protected IIncomeService IncomeService { get; set; }

        [Inject]
        protected IIncomeTypeService IncomeTypeService { get; set; } 

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        public IncomeRecord IncomeRecords { get; set; }
        private List<IncomeType> IncomeTypes { get; set; }
        protected override async Task OnInitializedAsync()
        {
            IncomeRecords = await IncomeService.GetIncomeID(Id);
            IncomeTypes = await IncomeTypeService.GetIncomeTypeList();
        }

        private async void SubmitIncome()
        {
            await IncomeService.UpdateIncomeRecord(IncomeRecords);

            NavigationManager.NavigateTo("/incomes");
        }


    }
}
