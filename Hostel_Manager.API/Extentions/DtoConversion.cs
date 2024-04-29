using Hostel_Manager.API.Entities;
using Hostel_Manager.Models.Dtos;

namespace Hostel_Manager.API.Extentions
{
    public static class DtoConversion
    {
        public static IEnumerable<HostelDto> ConvertToDto(this IEnumerable<Hostel> hostels, IEnumerable<User> users, 
            IEnumerable<Address> addresses)
        {
            return (from hostel in hostels
                    join User in users on hostel.Owner equals User.Id
                    join Address in addresses on hostel.Hostel_address equals Address.Id
                    where hostel.Owner == User.Id
                    select new HostelDto
                    {
                        Id = hostel.Id,
                        Hostel_name = hostel.Hostel_name,
                        City = Address.City,
                        District = Address.District,
                        Ward = Address.Ward,
                        Detail = Address.Detail,
                        OwnerHostel = User.Username,
                        Hostel_discription = hostel.Hostel_discription,
                        Parking = hostel.Parking,
                        Available = hostel.Available,
                        Image_Hostel = hostel.Image_Hostel,
                        Create = hostel.Create, 
                        Hostel_phone = hostel.Hostel_phone
                    }).ToList();
        }
    }
}
