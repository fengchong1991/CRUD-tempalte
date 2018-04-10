using CRUB_Generic.DAL;
using CRUB_Generic.DAL.Repositories;
using CRUD_Generic.Core.Data;
using CRUD_Generic.DAL;
using CRUD_Generic.DAL.CRUDDbContext;
using CRUD_Generic.DAL.Repositories;
using CRUD_Generic.Service;
using CRUD_Generic.Web.App_Start;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace CRUD_Generic.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>  
        /// Starts the application  
        /// </summary>  
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>  
        /// Stops the application.  
        /// </summary>  
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>  
        /// Creates the kernel that will manage your application.  
        /// </summary>  
        /// <returns>The created kernel.</returns>  
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>  
        /// Load your modules or register your services here!  
        /// </summary>  
        /// <param name="kernel">The kernel.</param>  
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IDbContext>().To<CRUDDbContext>().InRequestScope();
            kernel.Bind<IUserRepository>().To<UserRepository>().InRequestScope();


            kernel.Bind<IUserService>().To<UserService>();

        }
    }
}