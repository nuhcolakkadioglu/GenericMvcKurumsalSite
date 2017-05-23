using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcKurumsalSite.Infrasturcture.Repository
{
    public interface IRepository<T> 
    {
        IList<T> GetAll();
        IList<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T GetById(Expression<Func<T, bool>> predicate);
        T Insert(T model);
        void Update(T model);
        void Delete(T model);
        void Delete(int id);

    }
}
