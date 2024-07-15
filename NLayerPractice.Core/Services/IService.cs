using System.Linq.Expressions;

namespace NLayerPractice.Core.Services
{
    public interface IService<T> where T : class
    {

        //Return types diffrent from IGenericRepository
        Task<T> GetByIdAsync(int id);


        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
