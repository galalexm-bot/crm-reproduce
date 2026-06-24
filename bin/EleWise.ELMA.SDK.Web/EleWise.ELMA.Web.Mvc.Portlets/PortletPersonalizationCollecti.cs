using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Serializable]
public class PortletPersonalizationCollection : List<PortletPersonalization>
{
	public PortletPersonalizationCollection()
	{
	}

	public PortletPersonalizationCollection(int capacity)
		: base(capacity)
	{
	}

	public PortletPersonalizationCollection(IEnumerable<PortletPersonalization> collection)
		: base(collection)
	{
	}

	public PortletPersonalization Get(Guid portletUid, Guid instanceId)
	{
		return Find((PortletPersonalization item) => item.PortletUid == portletUid && item.InstanceId == instanceId);
	}

	public bool Has(Guid portletUid)
	{
		List<PortletPersonalization> list = this.Where((PortletPersonalization item) => item.PortletUid == portletUid).ToList();
		if (list.Count == 0)
		{
			return false;
		}
		return list.Any((PortletPersonalization d) => !d.Closed);
	}

	public PortletPersonalizationCollection FindClosed(bool closed)
	{
		return new PortletPersonalizationCollection(FindAll((PortletPersonalization item) => item.Closed == closed));
	}
}
