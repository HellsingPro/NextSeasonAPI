using Microsoft.Practices.Unity;
using NS.Business;
using NS.Domain.Contracts.Repositories;
using NS.Domain.Contracts.Services;
using NS.Domain.Contracts.UnitOfWork;
using NS.Infra.Context;
using NS.Infra.UnitOfWork;
using NS.Infra.Utility;


namespace NS.Startup
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            #region Contexto

            container.RegisterType<ContextCore, ContextCore>(new HierarchicalLifetimeManager());

            #endregion Contexto

            #region Repositorio

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IConnectionFactory, ConnectionFactory>(new HierarchicalLifetimeManager());

            #endregion Repositorio

            #region Service

            container.RegisterType<IMainService, MainService>(new HierarchicalLifetimeManager());

            #endregion Service

            #region Modelos

            //container.RegisterType<MENSAGEM, MENSAGEM>(new HierarchicalLifetimeManager());

            #endregion Modelos
        }
    }
}
