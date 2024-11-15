using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.DataAccess.UnitofWork;
using Udemy.ToDoAppNTier.Business.Interfaces;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;
using Udemy.ToDoAppNTier.Entities.Domains;

namespace Udemy.ToDoAppNTier.Business.Services
{
    internal class WorkService : IWorkService
    {
        private readonly IUow _uow;

        public WorkService(IUow uow)
        {
            _uow = uow;
        }

        public async Task Create(WorkCreateDto dto)
        {
            await _uow.GetRepository<Work>().Create(new()
            {
                IsCompleted = dto.IsCompleted,
                Definition = dto.Definition,
            });

            await _uow.SaveChanges();
        }

        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();

            var workList = new List<WorkListDto>();

            if (list != null && list.Count > 0)
            {
                foreach (var work in list)
                {
                    workList.Add(new()
                    {
                        Definition = work.Definition,
                        Id = work.Id,
                        IsCompleted = work.IsCompleted,
                    });
                }
            }
            return workList;
        }

        public async Task<WorkListDto> GetById(int id)
        {
            var work = await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id);

            return new()
            {
                Definition = work.Definition,
                IsCompleted = work.IsCompleted,
            };
        }

        public Task<WorkListDto> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int id)
        {
            _uow.GetRepository<Work>().Remove(id);
            await _uow.SaveChanges();
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(new()
            {
                Definition = dto.Definition,
                Id = dto.Id,
                IsCompleted = dto.IsCompleted,
            });

            await _uow.SaveChanges();
        }
    }
}