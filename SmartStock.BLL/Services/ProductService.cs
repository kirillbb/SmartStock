using SmartStock.BLL.DTOs.ProductType;
using SmartStock.BLL.Interfaces;
using SmartStock.BLL.Mappers;
using SmartStock.CORE.Entities.ProductType;
using SmartStock.DAL.Data;
using SmartStock.DAL.Interfaces;
using SmartStock.DAL.Repositories;

namespace SmartStock.BLL.Services
{
    public class ProductService : IService<ProductDto>
    {
        private readonly IRepository<Product> _repository;

        public ProductService()
        {
            DbContextFactory contextFactory = new DbContextFactory();
            _repository = new GenericRepository<Product>(contextFactory.CreateDbContext());
        }

        public async Task CreateAsync(ProductDto item)
        {
            await _repository.CreateAsync(Mapper<ProductDto, Product>.Map(item));
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>>? GetPagedAsync(int page, int pageSize)
        {
            return Mapper<Product, ProductDto>.MapAll(await _repository.GetPagedAsync(page, pageSize));
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            return Mapper<Product, ProductDto>.MapAll(await _repository.GetAllAsync());
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            return Mapper<Product, ProductDto>.Map(await _repository.GetAsync(id));
        }

        public async Task UpdateAsync(ProductDto item)
        {
            await _repository.UpdateAsync(Mapper<ProductDto, Product>.Map(item));
        }
    }
}