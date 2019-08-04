using Microsoft.Practices.Unity;
using Infrastructure.Interfaces;
using InfrastructureServices.Repositories;

namespace DependencyInjection.Modules
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IClientRepository, FakeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAccountRepository, FakeRepository>(new HierarchicalLifetimeManager());
        }
    }
}
