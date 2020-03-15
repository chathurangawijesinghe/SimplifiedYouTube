using System;
using System.Collections.Generic;
using System.Text;

namespace Kaddis.Framework.Utilities.Mapper
{
    public interface IGenericMapper<S, D> where S : class where D : class
    {
        D ConvertToDto(S s);

        List<D> ConvertToDtos(List<S> s);

        S ConvertToEntity(D d);

        List<S> ConvertToEntities(List<D> d);
    }
}
