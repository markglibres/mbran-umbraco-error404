﻿using System;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace MBran.Error404.Service
{
    public class SiteService : ISiteService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public SiteService()
        {
            _umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
        }

        public IPublishedContent GetDomainRoot()
        {
            var domainId = GetDomainRootId();
            return domainId == 0 ? null : _umbracoHelper.TypedContent(domainId);
        }

        public IPublishedContent GetByNodeId(int nodeId)
        {
            return _umbracoHelper.TypedContent(nodeId);
        }

        public int GetDomainRootId()
        {
            var domainName = HttpContext.Current.Request.Url.Host;
            var domainService = ApplicationContext.Current.Services.DomainService;

            return domainService
                       ?.GetAll(true)
                       .FirstOrDefault(domain => domain.DomainName.Equals(domainName,
                           StringComparison.InvariantCultureIgnoreCase))
                       ?.RootContentId.GetValueOrDefault()
                   ?? _umbracoHelper.TypedContentAtRoot().FirstOrDefault()?.Id
                   ?? 0;
        }
    }
}