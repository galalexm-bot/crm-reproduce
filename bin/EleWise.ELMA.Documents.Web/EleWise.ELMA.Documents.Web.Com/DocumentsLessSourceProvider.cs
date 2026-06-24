using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 250)]
internal class DocumentsLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.Documents.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.Documents.Web/Content/";

	public string FileName => "index.less";
}
