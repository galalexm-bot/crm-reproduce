using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Binders;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IValueProviderFactory
{
	IValueProvider GetValueProvider(ControllerContext controllerContext);
}
