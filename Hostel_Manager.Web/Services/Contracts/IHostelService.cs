using Hostel_Manager.Models.Dtos;

namespace Hostel_Manager.Web.Services.Contracts
{
    public interface IHostelService
    {
        Task<IEnumerable<HostelDto>> GetItems();
    }
}
