using Hostel_Manager.Models.Dtos;
using Hostel_Manager.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Hostel_Manager.Web.Services
{
    public class HostelService : IHostelService
    {
        private readonly HttpClient httpClient;

        public HostelService(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<HostelDto>> GetItems()
        {
            var hostels = await this.httpClient.GetFromJsonAsync<IEnumerable<HostelDto>>("api/Hostel");
            return hostels;
        }
    }
}
