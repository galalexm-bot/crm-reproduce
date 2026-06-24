using System.Web.Mvc;

namespace Orchard.Mvc.ViewEngines;

public interface IViewEngineProvider : ISingletonDependency, IDependency
{
	IViewEngine CreateThemeViewEngine(CreateThemeViewEngineParams parameters);

	IViewEngine CreateModulesViewEngine(CreateModulesViewEngineParams parameters);

	IViewEngine CreateBareViewEngine();
}
