using App.Models;

namespace App.Data.Repositories
{
    public interface IUserDeviceRepository
    {
        Task AssignDeviceToUser(AssignDeviceToUserRequest request);
        Task RemoveDeviceFromUser(RemoveDeviceFromUserRequest request);
        Task<GetUserDevicesResponse> GetUserDevices(GetUserDevicesRequest request);

    }
}
