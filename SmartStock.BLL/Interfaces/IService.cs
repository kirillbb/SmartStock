namespace SmartStock.BLL.Interfaces
{
    public interface IService<T>
    {
        Task CreateAsync(T item);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(T item);

        Task<T> GetAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();
    }
}