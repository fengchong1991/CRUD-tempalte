using CRUD_Generic.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly IDbContext _context;
        protected IDbSet<T> _entities;

        public BaseRepository(IDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }


        public T GetById(object id)
        {
            return this._entities.Find(id);
        }

        public int Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public int Insert(T entity)
        {
            _entities.Add(entity);
            return SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        protected int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //Thrown when there is a concurrency error
                //If Entries propery is null, no records were modified
                //entities in Entries threw error due to timestamp/conncurrency
                //for now, just rethrow the exception
                throw;
            }
            catch (DbUpdateException ex)
            {
                //Thrown when database update fails
                //Examine the inner exception(s) for additional 
                //details and affected objects
                //for now, just rethrow the exception
                throw;
            }
            catch (CommitFailedException ex)
            {
                //handle transaction failures here
                //for now, just rethrow the exception
                throw;
            }
            catch (Exception ex)
            {
                //some other exception happened and should be handled
                throw;
            }
        }


        public IQueryable<T> Table => _entities;

    }
}
