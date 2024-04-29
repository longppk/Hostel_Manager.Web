using Hostel_Manager.API.Entities;
using Hostel_Manager.API.Extentions;
using Hostel_Manager.API.Repositories.Contract;
using Hostel_Manager.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hostel_Manager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly IHostelRepository hostelRepository;

        public HostelController(IHostelRepository hostelRepository)
        {
            this.hostelRepository = hostelRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HostelDto>>> GetItems()
        {
            try
            {
                var hostels = await this.hostelRepository.GetItems();
                var users = await this.hostelRepository.GetUsers();
                var addresses = await this.hostelRepository.GetAddresses();
                if(hostels == null)
                {
                    return NotFound();
                }
                else
                {
                    var hostelDtos = hostels.ConvertToDto(users, addresses);
                    return Ok(hostelDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving data from the database");
            }
        }
    }
}
