using System.Web.Routing;
using Orchard;
using Orchard.Themes;

namespace EleWise.ELMA.BPM.Web.Common.Services;

public class ThemeSelector : IThemeSelector, IDependency
{
	private readonly ThemeSelectorResult selectorResult = new ThemeSelectorResult
	{
		Priority = 10,
		ThemeName = "ELMATheme"
	};

	public ThemeSelectorResult GetTheme(RequestContext context)
	{
		return selectorResult;
	}
}
