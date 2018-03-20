using Umbraco.Core.Models;

namespace MBran.Error404.Service
{
    public interface IError404Service
    {
        IPublishedContent GetError404();
        bool HasError404Property(IPublishedContent content);
        IPublishedContent GetError404ByDocType(IPublishedContent content);
        IPublishedContent GetError404ByProperty(IPublishedContent content);

    }
}