using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IExternalLessSourceProvider : IAbstractLessSourceProvider
{
	string Prefix { get; }

	bool ShouldRender(HtmlHelper htmlHelper);
}
