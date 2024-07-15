using Microsoft.EntityFrameworkCore;
using NLayerPractice.Core.Repositories;
using NLayerPractice.Core.Services;
using NLayerPractice.Core.UnitOfWorks;
using NLayerPractice.Service.Exceptions;
using System.Linq.Expressions;

namespace NLayerPractice.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        //For saveChange
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var hasProduct = await _repository.GetByIdAsync(id);

            //Exception
            if (hasProduct == null)
            {
                throw new NotFoundException($"{typeof(T).Name}({id}) not found.");
            }

            return hasProduct;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
