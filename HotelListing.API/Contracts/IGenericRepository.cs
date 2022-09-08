namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> Addsync(T entity);
        Task DeleteSync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
