using UMicro.Services.Catalog.Dtos;
using UMicro.Services.Catalog.Models;
using UMicro.Shared.Dtos;

namespace UMicro.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
