using Umbraco.Core.Models;
using Umbraco.Web;

namespace MBran.Error404.Service
{
    public class Error404Service : IError404Service
    {
        private const string Error404Property = "error404";
        private readonly ISiteService _siteService;

        public Error404Service(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public IPublishedContent GetError404Page()
        {
            var domainRoot = _siteService.GetDomainRoot();
            IPublishedProperty error404 = null;
            if (!domainRoot.HasProperty(Error404Property) 
                || !(error404 = domainRoot.GetProperty(Error404Property)).HasValue) { return domainRoot; }

            return _siteService.GetByNodeId(error404.GetValue<int>());
        }
    }
}