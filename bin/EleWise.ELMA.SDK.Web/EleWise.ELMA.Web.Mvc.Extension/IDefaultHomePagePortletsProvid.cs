using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDefaultHomePagePortletsProvider
{
	IEnumerable<DefaultHomePagePortlet> Portlets();
}
