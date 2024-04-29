using Hostel_Manager.API.Data;
using Hostel_Manager.API.Entities;
using Hostel_Manager.API.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace Hostel_Manager.API.Repositories
{
    public class HostelRepository : IHostelRepository
    {
        private readonly HostelDbContext hostelDbContext;

        public HostelRepository(HostelDbContext hostelDbContext)
        {
            this.hostelDbContext = hostelDbContext;
        }

        public async Task<IEnumerable<Address>> GetAddresses()
        {
            var addresses = await this.hostelDbContext.Addresses.ToListAsync();
            return addresses;
        }

        public Task<Address> GetIems(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<Hostel>> GetItems()
        {
            var hostels = await this.hostelDbContext.Hostels.ToListAsync();
            return hostels;
        }

        public Task<Hostel> GetItems(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await this.hostelDbContext.Users.ToListAsync();
            return users;
        }
    }
}
