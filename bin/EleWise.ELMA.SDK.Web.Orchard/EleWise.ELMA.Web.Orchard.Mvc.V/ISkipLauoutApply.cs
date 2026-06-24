using System.Web.Mvc;
using Orchard;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.ThemeAwareness;

public interface ISkipLauoutApply : IDependency
{
	bool Skip(ControllerContext controllerContext);
}
