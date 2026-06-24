using System.Web.Mvc;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterMenuProviderExtension
{
	bool SupportedFilter(IFilterFolder filterFolder);

	void GetTreeNodeParameters(IFilterFolder filterFolder, UrlHelper urlHelper, bool isDefault, bool isSystemDefault, out string type, out string icon, out string href, out bool canMakeDefault, ActionRoute routes, string filterIdParameter = null, string action = null);
}
