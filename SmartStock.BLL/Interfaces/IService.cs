namespace SmartStock.BLL.Interfaces
{
    public interface IService<T>
    {
        Task CreateAsync(T item);

        Task DeleteAsync(int id);

        Task UpdateAsync(T item);

        Task<T> GetAsync(int id);

        Task<List<T>>? GetAllPagedAsync(int page, int pageSize);

        Task<List<T>> GetAllAsync();
    }
}