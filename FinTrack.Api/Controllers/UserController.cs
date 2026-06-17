using FinTrack.Api.DTOs.Users;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateUserRequest request)
    {
        return Ok(new
        {
            message = "User received successfully",
            request.Name,
            request.Email
        });
    }
}