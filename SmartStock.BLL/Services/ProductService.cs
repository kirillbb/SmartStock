using SmartStock.BLL.DTOs.ProductType;
using SmartStock.BLL.Interfaces;

namespace SmartStock.BLL.Services
{
    public class ProductService : IService<ProductDto>
    {
        public Task CreateAsync(ProductDto item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductDto item)
        {
            throw new NotImplementedException();
        }
    }
}