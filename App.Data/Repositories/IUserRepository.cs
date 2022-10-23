using App.Models;

namespace App.Data.Repositories
{
    public interface IUserRepository
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<int> Create(CreateUserRequest request);
        Task Delete(DeleteUserRequest request);
    }
}
