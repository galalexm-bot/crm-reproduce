using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IModuleSettingsItemProvider
{
	IEnumerable<LinkButton> GetItems(UrlHelper urlHelper);

	bool Check(string id);
}
