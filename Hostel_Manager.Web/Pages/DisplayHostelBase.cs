using Hostel_Manager.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Hostel_Manager.Web.Pages
{
    public class DisplayHostelBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<HostelDto> hostels { get; set; }
    }
}
