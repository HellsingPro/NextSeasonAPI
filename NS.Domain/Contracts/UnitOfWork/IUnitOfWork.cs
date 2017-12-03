using NS.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.Domain.Contracts.UnitOfWork
{
    public interface IUnitOfWork
    {
        IMainRepository MainRepository { get; }

        void Commit();
    }
}
