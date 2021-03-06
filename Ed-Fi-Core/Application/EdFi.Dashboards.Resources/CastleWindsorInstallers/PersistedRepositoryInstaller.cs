using System;
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EdFi.Dashboards.Common;
using EdFi.Dashboards.Data.Repository;
using EdFi.Dashboards.Infrastructure.Data;

namespace EdFi.Dashboards.Resources.CastleWindsorInstallers
{
    public class PersistedRepositoryInstaller<T> : RepositoryInstaller<T>
    {
        protected override void RegisterGenericRepositories(IWindsorContainer container, IEnumerable<Type> entityTypes)
        {
            foreach (var entityType in entityTypes)
                if (!container.Kernel.HasComponent(CreateGenericType(typeof(IPersistingRepository<>), entityType)))
                {
                    // Get base entity type (will be same as entity type unless entity type is an extended type)
                    var baseEntityType = entityType.GetBaseEntityTypeForServiceRegistration();

                    container.Register(
                        Component
                            .For(CreateGenericType(typeof(IRepository<>), baseEntityType))
                            .Forward(CreateGenericType(typeof(IPersistingRepository<>), baseEntityType))
                            .ImplementedBy(CreateGenericType(typeof(PersistingRepository<>), entityType))
                            .DependsOn(Dependency.OnComponent("dbConnectionStringSelector", "Default Database Selector")));  // This assumes that the only database we persist to is the default connection string in the web.config file.
                }
        }
    }
}