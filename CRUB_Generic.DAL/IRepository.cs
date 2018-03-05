using CRUD_Generic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.DAL
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        T GetById(object id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        IQueryable<T> Table { get; }

    }
}
