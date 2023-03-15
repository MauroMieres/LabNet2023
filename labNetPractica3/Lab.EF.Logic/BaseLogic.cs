using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public abstract class BaseLogic<T> : IABMLogic<T> where T : class
    {
        protected readonly NorthWindContext _northWindContext;

        public BaseLogic()
        {
            _northWindContext = new NorthWindContext();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _northWindContext.Set<T>().ToList();
        }

        public virtual void Delete(T entity)
        {
            _northWindContext.Set<T>().Remove(entity);
            _northWindContext.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return _northWindContext.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
            _northWindContext.Set<T>().Add(entity);
            _northWindContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _northWindContext.Entry(entity).State = EntityState.Modified;
            _northWindContext.SaveChanges();
        }
    }
}
