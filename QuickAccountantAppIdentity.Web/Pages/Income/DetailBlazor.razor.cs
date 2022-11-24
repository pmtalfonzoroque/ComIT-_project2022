using Microsoft.AspNetCore.Components;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.web.Services.Interfaces;
using System.Numerics;

namespace QuickAccountantAppIdentity.Web.Pages.Income
{
    public partial class DetailBlazor
    {
        [Inject]
        protected IIncomeService IncomeService { get; set; }
        [Parameter]
        public int Id { get; set; }

        public IncomeRecord IncomeRecord { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IncomeRecord = await IncomeService.GetIncomeID(Id);
        }

    }
}
