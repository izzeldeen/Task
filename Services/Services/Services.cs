using DataAcces;
using Microsoft.EntityFrameworkCore;
using Repoistory.IRepository;
using Repoistory.Repository;
using Services.Dto;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.Services
{
    public class Services<T> : IServices<T> where T : class
    {
        
        private readonly IRepository<T> _repository;


        public Services(IRepository<T> repoistory)
        {
            _repository = repoistory;

        }
        public void Add(T entity)
        {
             _repository.Add(entity);
        }

        public T get(int Id)
        {
            return _repository.get(Id);
        }

        public IEnumerable<EmployeeDto> GetAll(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

      
    }
}
