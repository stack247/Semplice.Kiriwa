using System;
using System.Configuration;
using Highway.Data;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Semplice.Kiriwa.SL;
using Semplice.Kiriwa.SL.Contracts;
using Semplice.Kiriwa.WebApp.Areas.Probe.Controllers;
using Semplice.Kiriwa.WebApp.DataMappings;

namespace Semplice.Kiriwa.WebApp.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // Highway Data
            //This is Highway.Data's Context
            container.RegisterType<IDataContext, DataContext>(new InjectionConstructor(ConfigurationManager.ConnectionStrings["Kiriwa.SqlServer"].ToString(), typeof(IMappingConfiguration)));
            //This is Highway.Data's Repository
            container.RegisterType<IRepository, Repository>();
            //This is Highway.Data's relational mappings Interface, but YOUR implementation
            container.RegisterType<IMappingConfiguration, GettingStartedMappings>();
            //This is Highway.Data's context configuration, by default use the default :-)
            //Component.For<IContextConfiguration>().ImplementedBy<DefaultContextConfiguration>());

            // Web API Controller
            container.RegisterType<ObliqController>();

            // Services
            container.RegisterType<IObliqService, ObliqService>();
        }
    }
}
