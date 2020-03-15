using AutoMapper;
using System;
using System.Collections.Generic;

namespace Kaddis.Framework.Utilities.Mapper
{
    public class GenericMapper<S, D> : Profile, IGenericMapper<S, D> where S : class where D : class
    {
        public GenericMapper()
        {
            //CreateMap<S, D>();

        }

        public D ConvertToDto(S s)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<S, D>();

            });

            IMapper iMapper = config.CreateMapper();
            var destination = iMapper.Map<S, D>(s);

            return destination;
        }

        public List<D> ConvertToDtos(List<S> s)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<S, D>();

            });

            IMapper iMapper = config.CreateMapper();
            var destinationList = iMapper.Map<List<S>, List<D>>(s);

            return destinationList;
        }

        public S ConvertToEntity(D d)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<D, S>();

            });

            IMapper iMapper = config.CreateMapper();
            var source = iMapper.Map<D, S>(d);

            return source;
        }

        public List<S> ConvertToEntities(List<D> d)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<D, S>();

            });

            IMapper iMapper = config.CreateMapper();
            var sourceList = iMapper.Map<List<D>, List<S>>(d);

            return sourceList;
        }
    }
}
