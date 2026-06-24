using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

[Service(Type = ComponentType.Web)]
public class PortletPersonalizationLoader : IPortletPersonalizationLoader
{
	public IPortletPersonalization Load(int portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path)
	{
		return Locator.GetServiceNotNull<PortletManager>().Create((PersonalizationScope)portletManagerScope, portletManagerPath).GetPersonalization(portletId, instanceId, path);
	}
}
