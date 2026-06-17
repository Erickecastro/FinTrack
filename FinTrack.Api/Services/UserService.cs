using FinTrack.Api.DTOs.Users;

namespace FinTrack.Api.Services;

public class UserService
{
    public object Create(CreateUserRequest request)
    {
        return new
        {
            Message = "User received successfully",
            Name = request.Name,
            Email = request.Email
        };
    }
}