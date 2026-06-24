using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[Component(Order = int.MinValue)]
public class LayoutLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string ContentPath => "~/Content";

	public string FileName => "index.less";

	public string Area => "EleWise.ELMA.SDK.Web";
}
