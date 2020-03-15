using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Utilities.Service
{
    public interface IGenericService<D> where D : class
    {
        Task<IEnumerable<D>> GetAll();

        Task<D> GetById(object Id);

        Task<D> Insert(D obj);

        Task Delete(object Id);

        Task Update(D obj);

        Task Save();
    }
}
