using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Component]
internal sealed class PortletV2Provider : IPortletProvider
{
	private readonly ComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	public PortletV2Provider(ComponentMetadataItemHeaderManager componentMetadataItemHeaderManager)
	{
		this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
	}

	public IEnumerable<IPortlet> GetPortlets()
	{
		ComponentMetadataItemHeaderFilter componentMetadataItemHeaderFilter = InterfaceActivator.Create<ComponentMetadataItemHeaderFilter>();
		componentMetadataItemHeaderFilter.MetadataTypeUid = PortletComponentMetadata.TypeUid;
		componentMetadataItemHeaderFilter.IsPublished = true;
		return (from header in componentMetadataItemHeaderManager.Find(componentMetadataItemHeaderFilter, FetchOptions.All)
			select new PortletV2(header.Published)).ToList();
	}

	public IPortlet GetPortlet(Guid uid)
	{
		ComponentMetadataItemHeader componentMetadataItemHeader = componentMetadataItemHeaderManager.LoadOrNull(uid);
		if (componentMetadataItemHeader?.Published == null)
		{
			return null;
		}
		return new PortletV2(componentMetadataItemHeader.Published);
	}
}
