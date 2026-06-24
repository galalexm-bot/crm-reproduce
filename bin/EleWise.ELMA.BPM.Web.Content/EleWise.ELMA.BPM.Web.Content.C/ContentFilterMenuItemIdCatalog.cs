using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Content.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class ContentFilterMenuItemIdCatalogsExtension : IContentFilterMenuItemIdExtension
{
	public IComponentManager ComponentManager { get; set; }

	public FilterMenuProvider FilterMenuProvider { get; set; }

	public bool SetParameters(IFilterActionLink action, ActionRoute route, ref bool canMakeDefault)
	{
		FilterMenuItem filterMenuItem = FilterMenuProvider.FilterMenuItemByCode("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root").FirstOrDefault((FilterMenuItem e) => e.TypeUid == action.ObjectsType.TypeUid);
		if (filterMenuItem != null)
		{
			route.Routes.Add("activeMenuItemCode", filterMenuItem.Code);
			route.Routes.Add("showFiltersTreeForType", filterMenuItem.TypeUid);
			canMakeDefault = true;
			return true;
		}
		return false;
	}
}
