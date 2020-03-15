using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Utilities.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object Id);
        Task<T> Insert(T obj);
        Task Delete(object Id);
        Task Update(T obj);
        Task Save();
    }
}
