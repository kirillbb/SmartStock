using SmartStock.BLL.DTOs.OrderType;
using SmartStock.BLL.Interfaces;
using SmartStock.BLL.Mappers;
using SmartStock.CORE.Entities.OrderType;
using SmartStock.DAL.Data;
using SmartStock.DAL.Interfaces;
using SmartStock.DAL.Repositories;

namespace SmartStock.BLL.Services
{
    public class OrderService : IService<OrderDto>
    {
        private readonly IRepository<Order> _repository;

        public OrderService()
        {
            DbContextFactory contextFactory = new DbContextFactory();
            _repository = new GenericRepository<Order>(contextFactory.CreateDbContext());
        }

        public async Task CreateAsync(OrderDto item)
        {
            await _repository.CreateAsync(Mapper<OrderDto, Order>.Map(item));
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            return Mapper<Order, OrderDto>.MapAll(await _repository.GetAllAsync());
        }

        public async Task<OrderDto> GetAsync(int id)
        {
            return Mapper<Order, OrderDto>.Map(await _repository.GetAsync(id));
        }

        public async Task<List<OrderDto>>? GetPagedAsync(int page, int pageSize)
        {
            return Mapper<Order, OrderDto>.MapAll(await _repository.GetPagedAsync(page, pageSize));
        }

        public async Task UpdateAsync(OrderDto item)
        {
            await _repository.UpdateAsync(Mapper<OrderDto, Order>.Map(item));
        }
    }
}