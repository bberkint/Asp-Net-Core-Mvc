﻿using System;
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

        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();

            var workList = new List<WorkListDto>();

            if (list != null && list.Count > 0)
            {
                foreach (var work in list)
                {
                    workList.Add(new() { 
                        Definition = work.Definition,
                        Id = work.Id,
                        IsCompleted = work.IsCompleted,
                    });
                }
            }
            return workList;
        }
    }
}