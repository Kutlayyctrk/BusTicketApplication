using AutoMapper;
using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.Models.Entities;
using BusTicketApplication.Core.RepositoryInterfaces;
using BusTicketApplication.Core.ServiceInterfaces;
using BusTicketApplication.Core.UnitOfWorkInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Service.Services
{
    public class Service<TEntity, TDto> : IService<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDto
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<TDto> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            await _repository.AddAsync(entity);

            await _unitOfWork.CommitAsync();

            var newDto = _mapper.Map<TDto>(entity);
            return newDto;
        }

        public async Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TEntity>>(dtos);
            foreach (var entity in entities)
            {
                await _repository.AddAsync(entity);
            }
            await _unitOfWork.CommitAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }
        

        public async Task RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(TDto dto, int id)
        {
            var entity = _mapper.Map<TEntity>(dto);

            entity.Id = id;

            _repository.Update(entity);
            await _unitOfWork.CommitAsync();

        }

        public async Task<IEnumerable<TDto>> Where(Expression<Func<TEntity, bool>> expression)
        {
            var entities = await _repository.Where(expression).ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }
    }
}
