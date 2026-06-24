using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Designer.Web.Components;

[Component(Order = 300)]
internal class DesignerLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.Designer.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.Designer.Web/Content/";

	public string FileName => "index.less";
}
