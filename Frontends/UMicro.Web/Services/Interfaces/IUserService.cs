using UMicro.Web.Models;

namespace UMicro.Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();

    }
}
