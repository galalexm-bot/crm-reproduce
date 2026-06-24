using System;
using System.Web.Mvc;

namespace Orchard.Mvc.ViewEngines.ThemeAwareness;

public interface IConfiguredEnginesCache : ISingletonDependency, IDependency
{
	IViewEngine BindBareEngines(Func<IViewEngine> factory);

	IViewEngine BindShallowEngines(string themeName, Func<IViewEngine> factory);

	IViewEngine BindDeepEngines(string themeName, Func<IViewEngine> factory);
}
