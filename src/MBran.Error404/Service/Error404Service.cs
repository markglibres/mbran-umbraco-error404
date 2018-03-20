using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace MBran.Error404.Service
{
    public class Error404Service : IError404Service
    {
        private const string Error404Alias = "error404";
        
        private readonly ISiteService _siteService;

        public Error404Service(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public IPublishedContent GetError404()
        {
            var domainRoot = _siteService.GetDomainRoot();

            return GetError404ByProperty(domainRoot)
                   ?? GetError404ByDocType(domainRoot)
                   ?? domainRoot;
        }

        public IPublishedContent GetError404ByDocType(IPublishedContent content)
        {
            return content
                .DescendantsOrSelf(Error404Alias)
                .FirstOrDefault();
        }

        public IPublishedContent GetError404ByProperty(IPublishedContent content)
        {
            return HasError404Property(content)
                ? _siteService.GetByNodeId(content.GetProperty(Error404Alias).GetValue<int>())
                : null;
        }

        public bool HasError404Property(IPublishedContent content)
        {
            return content.HasProperty(Error404Alias)
                   && content.GetProperty(Error404Alias).HasValue;
        }

        
    }
}