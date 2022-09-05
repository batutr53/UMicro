using Microsoft.AspNetCore.Http;
using UMicro.Web.Models;

namespace UMicro.Web.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoViewModel> UploadPhoto(IFormFile photo);
        Task<bool> DeletePhoto(string photoUrl);
    }
}
