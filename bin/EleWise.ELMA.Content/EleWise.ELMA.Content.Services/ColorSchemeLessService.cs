using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Content.Services;

[Service(Scope = ServiceScope.Shell, EnableInterceptors = false)]
internal sealed class ColorSchemeLessService : IColorSchemeLessService
{
	private readonly ColorSchemeManager colorSchemeManager;

	public ColorSchemeLessService(ColorSchemeManager colorSchemeManager)
	{
		this.colorSchemeManager = colorSchemeManager;
	}

	public ColorSchemeLessModel GetScheme(string compiledCssSrc)
	{
		return colorSchemeManager.GetCurrentSchemeLessModel(compiledCssSrc);
	}

	public ColorSchemeCssModel GetCssScheme()
	{
		return colorSchemeManager.GetCurrentSchemeCssModel();
	}
}
