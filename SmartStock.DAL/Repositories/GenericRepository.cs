using Microsoft.EntityFrameworkCore;
using SmartStock.DAL.Data;
using SmartStock.DAL.Interfaces;

namespace SmartStock.DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity item)
        {
            await _dbSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _dbSet.Remove(await GetAsync(id));
            await _context.SaveChangesAsync();
        }

        public List<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(TEntity item)
        {
            _dbSet.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}