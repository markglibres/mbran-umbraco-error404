using Umbraco.Core.Models;

namespace MBran.Error404.Service
{
    public interface ISiteService
    {
        int GetDomainRootId();
        IPublishedContent GetDomainRoot();
        IPublishedContent GetByNodeId(int nodeId);
    }
}