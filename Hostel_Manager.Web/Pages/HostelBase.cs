using Hostel_Manager.Models.Dtos;
using Hostel_Manager.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Hostel_Manager.Web.Pages
{
    public class HostelBase : ComponentBase
    {
        [Inject]
        public IHostelService HostelService { get; set; }

        public IEnumerable<HostelDto> Hostels { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Hostels = await HostelService.GetItems();
        }


    }
}
