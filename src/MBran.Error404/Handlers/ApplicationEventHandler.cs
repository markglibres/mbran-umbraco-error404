using Umbraco.Core;
using Umbraco.Web.Routing;

namespace MBran.Error404.Handlers
{
    public class ApplicationEventHandler : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            ContentLastChanceFinderResolver.Current.SetFinder(new Error404Handler());
        }
    }
}