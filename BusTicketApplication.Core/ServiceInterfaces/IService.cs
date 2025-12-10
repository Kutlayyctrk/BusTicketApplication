using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.ServiceInterfaces
{
    public interface IService<TEntity, TDto> where TEntity:BaseEntity where TDto:BaseDto
    {
        Task<TDto> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<IEnumerable<TDto>> Where(Expression<Func<TEntity, bool>> expression);

        Task<TDto> AddAsync(TDto dto);
        Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TDto> dtos);

        Task UpdateAsync(TDto dto, int id);
        Task RemoveAsync(int id);
    }
}
