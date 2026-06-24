using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Themes;

public class ThemeManager : IThemeManager, IDependency
{
	private readonly IEnumerable<IThemeSelector> _themeSelectors;

	private readonly IExtensionManager _extensionManager;

	public ThemeManager(IEnumerable<IThemeSelector> themeSelectors, IExtensionManager extensionManager)
	{
		_themeSelectors = themeSelectors;
		_extensionManager = extensionManager;
	}

	public ExtensionDescriptor GetRequestTheme(RequestContext requestContext)
	{
		IOrderedEnumerable<ThemeSelectorResult> orderedEnumerable = from x in _themeSelectors
			select x.GetTheme(requestContext) into x
			where x != null
			orderby x.Priority descending
			select x;
		if (orderedEnumerable.Count() < 1)
		{
			return null;
		}
		foreach (ThemeSelectorResult item in orderedEnumerable)
		{
			ExtensionDescriptor extension = _extensionManager.GetExtension(item.ThemeName);
			if (extension != null)
			{
				return extension;
			}
		}
		return _extensionManager.GetExtension("SafeMode");
	}
}
