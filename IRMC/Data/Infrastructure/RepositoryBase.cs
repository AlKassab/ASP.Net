using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pidev.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private Model2 dataContext;
        private readonly IDbSet<T> dbset;
        public RepositoryBase(IDataBaseFactory factory)
        {
            this.dataContext = factory.DataContext;
            dbset = dataContext.Set<T>();
        }
        public void Add(T entity)
        {

            dbset.Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> objects = dbset.Where<T>(condition).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> condition)
        {
            return dbset.Where<T>(condition).FirstOrDefault<T>();
        }

        public IEnumerable<T> getAll()
        {
            return dbset.ToList();
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }
        

        public T GetById(long id)
        {
            return dbset.Find(id);
        }
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> query = dbset;
            if (condition != null)
                query = query.Where(condition);
            if (orderBy != null)
                query = query.OrderBy(orderBy);
            return query;
        }

        public void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
