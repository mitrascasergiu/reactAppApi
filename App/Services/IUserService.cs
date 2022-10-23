using App.Models;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IUserService
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<int> Create(CreateUserRequest request);
        Task Delete(DeleteUserRequest request);
    }
}
