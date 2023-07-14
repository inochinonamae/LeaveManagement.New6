using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)  //We call ApplicationDbContext context here
        {
            this.context = context;
        }
 
        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity; //Because there might be a situation where you need the data from an operation
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
            }
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
             return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //Do the same task as context.Update(entity);
            //context.Entry(entity).State = EntityState.Modified; 
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
