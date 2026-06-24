using System.Web.Mvc;
using Orchard;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.ThemeAwareness;

public class ThemeAttributesSkipLayoutApply : ISkipLauoutApply, IDependency
{
	public bool Skip(ControllerContext controllerContext)
	{
		if (!ThemeFilter.IsApplied(controllerContext.get_RequestContext()))
		{
			return true;
		}
		return false;
	}
}
