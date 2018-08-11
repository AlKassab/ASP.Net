using pidev.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ServicePattern
{
    public class EventService<T> : IEventService<T> where T : class
    {
        IUnitOfWork utk;
        public EventService(IUnitOfWork utk)
        {
            this.utk = utk;
        }
        public void Add(T entity)
        {
            utk.getRepository<T>().Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            utk.getRepository<T>().Delete(where);
        }

        public void Delete(T entity)
        {
            utk.getRepository<T>().Delete(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return utk.getRepository<T>().Get(where);
        }

        public T GetById(string id)
        {
            return utk.getRepository<T>().GetById(id);
        }

        public T GetById(long id)
        {
            return utk.getRepository<T>().GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            if (orderBy != null)
                return utk.getRepository<T>().GetMany(where, orderBy);
            else
                return utk.getRepository<T>().GetMany(where);
        }

        public void Update(T entity)
        {
            utk.getRepository<T>().Update(entity);
        }
        public void Commit()
        {
            try { utk.Commit(); }
            catch (Exception ex) { throw ex; }
        }
        public void Dispose()

        {
            utk.Dispose();
        }
    }
}
