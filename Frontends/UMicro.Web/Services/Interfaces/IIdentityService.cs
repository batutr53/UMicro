using IdentityModel.Client;
using UMicro.Shared.Dtos;
using UMicro.Web.Models;

namespace UMicro.Web.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SigninInput signinInput);
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
