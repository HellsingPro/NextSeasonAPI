using NS.Domain.Contracts.Repositories;
using NS.Domain.Contracts.UnitOfWork;
using NS.Infra.Repositories;
using NS.Infra.Utility;
using System;

namespace NS.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //public readonly IMensagemRepository _mensagemRepository;
        private readonly IConnectionFactory _connectionFactory;
        private readonly IMainRepository _mainRepository;

        public UnitOfWork()
        {
            _connectionFactory = new ConnectionFactory();
            _mainRepository = new MainRepository(_connectionFactory);
        }

        public IMainRepository MainRepository
        {
            get
            {
                return _mainRepository;
            }
        }

        //public IMensagemRepository MensagemRepository
        //{
        //    get
        //    {
        //        return _mensagemRepository;
        //    }
        //}

        public void Commit()
        {
            throw new NotImplementedException();
        }

    }
}
