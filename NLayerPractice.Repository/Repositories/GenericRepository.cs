using Microsoft.EntityFrameworkCore;
using NLayerPractice.Core.Repositories;
using System.Linq.Expressions;

namespace NLayerPractice.Repository.Repositories
{
    //I writed a CORS in Core Layer. Now, ı implement this here because this is about database.
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //I use protected access tokens because ı want to use "NLayerDbContext" wherever it is inherited.
        protected readonly NLayerDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(NLayerDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }



        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }


        public IQueryable<T> GetAll()
        {
            //I use AsNoTracking because ı don't want it to store the data it captures.
            //It is used to increase performance and reduce memory usage in read operations.
            //There won't record in the database, there isn't problem to use it.
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
