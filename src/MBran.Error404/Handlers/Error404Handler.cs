using MBran.Error404.Service;
using Umbraco.Web.Routing;

namespace MBran.Error404.Handlers
{
    public class Error404Handler : IContentFinder
    {
        public bool TryFindContent(PublishedContentRequest contentRequest)
        {
            if (!contentRequest.Is404)
            {
                return contentRequest.PublishedContent != null;
            }
            ISiteService siteService = new SiteService();
            IError404Service errorService = new Error404Service(siteService);

            contentRequest.SetResponseStatus(404, "404 Page Not Found");
            contentRequest.PublishedContent = errorService.GetError404Page();

            return contentRequest.PublishedContent != null;
        }
    }
}
