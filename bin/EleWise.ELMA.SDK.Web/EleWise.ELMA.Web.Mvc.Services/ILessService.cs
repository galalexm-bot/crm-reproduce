using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Services;

public interface ILessService
{
	string Bundle();

	bool TemporaryCssExists(string zone, string src);

	string GetTemporaryCss(string href);

	string GetTemporaryCssHref(string zone, string src);

	string CreateTemporaryCss(string zone, string src);

	LessFileModel ParseLess(string zone, string src);

	LessFileModel ParseLess(ILayoutLessSourceProvider lessSourceProvider, string src);

	LessFileModel ParseLess(string path);
}
