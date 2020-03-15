using System;

namespace Kaddis.Framework.Utilities.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
