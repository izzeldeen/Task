using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Services.IServices
{
    public interface IServices<T> where T: class
    {
        T get(int Id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int Id);
        void RemoveRange(IEnumerable<T> entity);
      
    }
}
