using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Data
{
    public interface IRepository<T> where T:BaseEntity
    {
        IList<T> GetAll();
        IList<T> GetAll(Expression<Func<T, bool>> where);
        T Get(string id);
        T Get(Expression<Func<T, bool>> where);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
