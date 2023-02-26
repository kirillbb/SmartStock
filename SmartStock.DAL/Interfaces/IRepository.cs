namespace SmartStock.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>>? GetPagedAsync(int page, int pageSize);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(int id);

        IEnumerable<T> Find(Func<T, Boolean> predicate);

        Task CreateAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(int id);
    }
}