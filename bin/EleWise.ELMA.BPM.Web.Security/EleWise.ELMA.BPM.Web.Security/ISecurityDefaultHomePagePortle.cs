using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISecurityDefaultHomePagePortletsProvider
{
	IEnumerable<SecurityDefaultHomePagePortlet> Portlets();
}
