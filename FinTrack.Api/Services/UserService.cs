using FinTrack.Api.DTOs.Users;

namespace FinTrack.Api.Services;

public class UserService
{
    public object Create(CreateUserRequest request)
    {
        return new
        {
            message = "User created successfully",
            request.Name,
            request.Email
        };
    }
}