using Umbraco.Core.Models;

namespace MBran.Error404.Service
{
    public interface IError404Service
    {
        IPublishedContent GetError404Page();
    }
}