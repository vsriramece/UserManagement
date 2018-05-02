using System;
using Rebtel.UserManagement.Infrastructure.Repository;
using Microsoft.Practices.Unity;
using Unity.Wcf;
using Rebtel.UserManagement.Infrastructure.Services;
using Unity.Lifetime;
using Unity;
using Rebtel.UserManagement.Infrastructure.UnitOfWork;
using System.ServiceModel;

namespace Rebtel.UserManagement.WCFService
{
   
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<UserManagementDBContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserCommandService, UserCommandService>();
            container.RegisterType<IUserQueryService, UserQueryService>();
            container.RegisterType<IUserManagement, UserManagement>();

            container.RegisterType<ISubscriptionRepository, SubscriptionRepository>();
            container.RegisterType<ISubscriptionCommandService, SubscriptionCommandService>();
            container.RegisterType<ISubscriptionQueryService, SubscriptionQueryService>();
            container.RegisterType<ISubscriptionManagement, SubscriptionManagement>();

        }
    }

}