using Microsoft.EntityFrameworkCore;

namespace VehicleTracking.Repositories.Implementations
{
    public class Repository<T> where T : class
    {
        protected readonly DataModels.Context Context;
        protected readonly DbSet<T> DbSet;

        public Repository(DataModels.Context context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            Context.SaveChanges();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<IQueryable<T>> GetAllAsync()
        {
            return DbSet.AsNoTracking();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual async Task RemoveAsync(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
    }
}
