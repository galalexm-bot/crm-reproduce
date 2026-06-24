using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IActionWebHandler
{
	void Process(IBaseController controller, string action, IValueProvider valueProvider, object target);
}
