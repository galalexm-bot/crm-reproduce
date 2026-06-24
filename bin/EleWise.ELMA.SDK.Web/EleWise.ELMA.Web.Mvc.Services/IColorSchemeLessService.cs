using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

public interface IColorSchemeLessService
{
	ColorSchemeLessModel GetScheme(string compiledCssSrc);

	ColorSchemeCssModel GetCssScheme();
}
