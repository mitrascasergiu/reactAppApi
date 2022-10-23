using App.Models;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IUserDeviceService
    {
        Task AssignDeviceToUser(AssignDeviceToUserRequest request);
        Task RemoveDeviceFromUser(RemoveDeviceFromUserRequest request);
        Task<GetUserDevicesResponse> GetUserDevices(GetUserDevicesRequest request);
    }
}
