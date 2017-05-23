using MvcKurumsalSite.Infrasturcture.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MvcKurumsalSite.Infrasturcture
{
    public  class GenericRepository<T> : IRepository<T>  where T:class
    {
        private ContextDb _context;

        public GenericRepository(ContextDb context)
        {
            _context = context;
        }

        private ContextDb Context
        {
            get { return _context; }
            set { _context = value;}
        }

        public virtual void Delete(T model)
        {
            _context.Set<T>().Remove(model);
        }

        public virtual IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Insert(T model)
        {
            return  _context.Set<T>().Add(model);
        }

        public virtual void Update(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual T GetById(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public virtual void Delete(int id)
        {
            var obj = _context.Set<T>().Find(id);
            Delete(obj);
        }
    }
}
