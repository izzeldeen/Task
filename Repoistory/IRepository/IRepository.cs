
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repoistory.IRepository
{
    public interface IRepository<T> where T : class
    {
        T get(int Id);
        IEnumerable<T> GetAll(
           Expression<Func<T, bool>> filter = null
           );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null
            );

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int Id);
        void RemoveRange(IEnumerable<T> entity);
    }
}

