using Hostel_Manager.API.Entities;

namespace Hostel_Manager.API.Repositories.Contract
{
    public interface IHostelRepository
    {
        Task<IEnumerable<Hostel>> GetItems();
        Task<IEnumerable<Address>> GetAddresses();
        Task<IEnumerable<User>> GetUsers();

        Task<Hostel> GetItems(int id);
        Task<Address> GetIems (int id);
        Task<User> GetUser (int id);
    }
}
