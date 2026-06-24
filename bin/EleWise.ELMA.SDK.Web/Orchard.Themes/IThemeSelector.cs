using System.Web.Routing;

namespace Orchard.Themes;

public interface IThemeSelector : IDependency
{
	ThemeSelectorResult GetTheme(RequestContext context);
}
