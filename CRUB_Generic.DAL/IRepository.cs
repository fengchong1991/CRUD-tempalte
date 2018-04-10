using CRUD_Generic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.DAL
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);

        void Update(T entity);

        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);

    }
}
