using Autofac;
using NLayerPractice.Core.Repositories;
using NLayerPractice.Core.Services;
using NLayerPractice.Core.UnitOfWorks;
using NLayerPractice.Repository;
using NLayerPractice.Repository.Repositories;
using NLayerPractice.Repository.UnitOfWorks;
using NLayerPractice.Service.Services;
using NLayerPractice.Service.Services.Mapping;
using System.Reflection;

namespace NLayerPractice.Web.Modules
{
    public class RepoServiceModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(NLayerDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();
            //InstancePerLifetimeScope = Scope
            //InstencePerDependency = Transient


            builder.RegisterGeneric(typeof(Service<>))
                .As(typeof(IService<>))
                .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

        }

    }
}
