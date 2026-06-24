using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 200)]
internal class CommonLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.BPM.Web.Common";

	public string ContentPath => "~/Modules/EleWise.ELMA.BPM.Web.Common/Content/";

	public string FileName => "index.less";
}
