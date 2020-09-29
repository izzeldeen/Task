using DataAcces;
using Microsoft.EntityFrameworkCore;
using Repoistory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repoistory.Repository
{
    public class Repoistory<T> : IRepository<T> where T : class
    {
        private readonly StoreContext _context;
        internal DbSet<T> dbSet;

        public Repoistory(StoreContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
            _context.SaveChanges();
        }

        public T get(int Id)
        {
            return dbSet.Find(Id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }

            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }
           

            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(int Id)
        {
            var entity = dbSet.Find(Id);
            dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
