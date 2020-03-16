using AutoMapper;
using Kaddis.Framework.Utilities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaddis.Framework.Utilities.Service
{
    public class GenericService<D, E> : IGenericService<D>
        where D : class
        where E : class
    {
        private IGenericRepository<E> repository;

        private IMapper mapper;

        public GenericService(IGenericRepository<E> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<D>> GetAll()
        {
            var data = await this.repository.GetAll();
            return mapper.Map<List<E>, List<D>>(data.ToList());
        }

        public async Task<D> GetById(object Id)
        {
            var data = await this.repository.GetById(Id);
            return mapper.Map<E, D>(data);
        }

        public async Task<D> Insert(D obj)
        {
            var data = await this.repository.Insert(mapper.Map<D, E>(obj));
            return mapper.Map<E, D>(data);
        }

        public async Task Save()
        {
            await this.repository.Save();
        }

        public async Task Update(D obj)
        {
            await repository.Update(mapper.Map<D, E>(obj));
        }

        public async Task Delete(object Id)
        {
            await this.repository.Delete(Id);
        }
    }
}
