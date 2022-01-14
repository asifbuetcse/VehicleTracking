namespace VehicleTracking.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IQueryable<T>> GetAllAsync();

        Task UpdateAsync(T entity);

        Task RemoveAsync(int id);
    }
}
