using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Component]
public class UIPortletProvider : IPortletProvider
{
	public FormDescriptorProvider FormDescriptorProvider { get; set; }

	public IEnumerable<IPortlet> GetPortlets()
	{
		return GetPortlets(forEmulation: false);
	}

	public IPortlet GetPortlet(Guid portletUid)
	{
		return GetPortlet(portletUid, forEmulation: false);
	}

	public IEnumerable<IPortlet> GetPortlets(bool forEmulation)
	{
		if (FormDescriptorProvider == null)
		{
			return new IPortlet[0];
		}
		return (from d in FormDescriptorProvider.GetDescriptors(PortletMetadata.TypeUid, forEmulation).OfType<PortletDescriptor>().ToList()
			orderby d.Metadata.DisplayName
			select new UIPortlet(d)).ToArray();
	}

	public IPortlet GetPortlet(Guid portletUid, bool forEmulation)
	{
		if (FormDescriptorProvider == null)
		{
			return null;
		}
		return GetPortlets(forEmulation).FirstOrDefault((IPortlet p) => p.Uid == portletUid);
	}
}
