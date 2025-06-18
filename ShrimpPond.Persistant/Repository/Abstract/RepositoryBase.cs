using Microsoft.EntityFrameworkCore;
using ShrimpPond.Application.Interface.Generic;
using ShrimpPond.Persistant.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Persistant.Repository.Abstract
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        private readonly ShrimpPondDbContext _context;

        public RepositoryBase(ShrimpPondDbContext context) {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges = false)
        {
            return !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void DeleteRange(IEnumerable<T> entities) { 
            _context.Set<T>().RemoveRange(entities);
        }
        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
