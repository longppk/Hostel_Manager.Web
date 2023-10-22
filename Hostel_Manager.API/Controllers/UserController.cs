using Hostel_Manager.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hostel_Manager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    private readonly 
    public class UserController : ControllerBase
    {

    }

    public async Task<IActionResult> LoginAsync([FromBody] UserDto model)
    {
        var result = await _user
    }
}
