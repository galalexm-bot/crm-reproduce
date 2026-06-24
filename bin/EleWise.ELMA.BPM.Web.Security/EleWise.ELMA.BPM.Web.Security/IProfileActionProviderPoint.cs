using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IProfileActionProviderPoint
{
	IEnumerable<IProfileAction> GetProfileActions(HtmlHelper html, IUser user);
}
