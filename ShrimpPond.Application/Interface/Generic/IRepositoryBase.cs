using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Interface.Generic
{
    public interface IRepositoryBase<T>
        where T : class
    {
        //IQueryable<T> GetAll();
        //IQueryable<T> Get(int id);
        public IQueryable<T> FindAll(bool x = false);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);

    }
}
