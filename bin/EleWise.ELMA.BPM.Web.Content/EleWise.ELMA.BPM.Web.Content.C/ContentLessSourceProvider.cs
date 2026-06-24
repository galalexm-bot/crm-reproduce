using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component(Order = 300)]
internal class ContentLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.BPM.Web.Content";

	public string ContentPath => "~/Modules/EleWise.ELMA.BPM.Web.Content/Content/";

	public string FileName => "index.less";
}
