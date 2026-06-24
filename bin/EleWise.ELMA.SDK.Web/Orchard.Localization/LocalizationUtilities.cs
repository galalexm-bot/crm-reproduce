using System.Web.Mvc;
using Autofac;
using Autofac.Core;

namespace Orchard.Localization;

public class LocalizationUtilities
{
	public static Localizer Resolve(WorkContext workContext, string scope)
	{
		if (workContext != null)
		{
			return Resolve((IComponentContext)(object)workContext.Resolve<ILifetimeScope>(), scope);
		}
		return NullLocalizer.Instance;
	}

	public static Localizer Resolve(ControllerContext controllerContext, string scope)
	{
		return Resolve(controllerContext.GetWorkContext(), scope);
	}

	public static Localizer Resolve(IComponentContext context, string scope)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return ResolutionExtensions.Resolve<IText>(context, (Parameter[])(object)new Parameter[1] { (Parameter)new NamedParameter("scope", (object)scope) }).Get;
	}
}
