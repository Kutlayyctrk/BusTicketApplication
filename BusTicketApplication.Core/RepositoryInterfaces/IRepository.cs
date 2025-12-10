using BusTicketApplication.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.RepositoryInterfaces
{
    public interface IRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);


        IQueryable<T> GetAll();


        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
