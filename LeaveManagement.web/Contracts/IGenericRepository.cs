namespace LeaveManagement.web.Contracts
{
    public interface IGenericRepository<T> where T : class //Here means T in <T> represent a class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
 
    }
}
