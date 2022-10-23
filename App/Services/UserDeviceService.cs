using App.Data;
using App.Models;
using System.Threading.Tasks;

namespace App.Services
{
    public class UserDeviceService : IUserDeviceService
    {
        private readonly IUnitOfWork _uow;

        public UserDeviceService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task AssignDeviceToUser(AssignDeviceToUserRequest request)
        {
            await _uow.UserDeviceRepository.AssignDeviceToUser(request);
            _uow.Commit();
        }

        public async Task RemoveDeviceFromUser(RemoveDeviceFromUserRequest request)
        {
            await _uow.UserDeviceRepository.RemoveDeviceFromUser(request);
            _uow.Commit();
        }

        public async Task<GetUserDevicesResponse> GetUserDevices(GetUserDevicesRequest request)
        {
            var result = await _uow.UserDeviceRepository.GetUserDevices(request);
            return result;
        }
    }
}
