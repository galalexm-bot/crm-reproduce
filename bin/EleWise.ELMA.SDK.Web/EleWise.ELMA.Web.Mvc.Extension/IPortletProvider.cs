using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IPortletProvider
{
	IEnumerable<IPortlet> GetPortlets();

	IPortlet GetPortlet(Guid uid);
}
