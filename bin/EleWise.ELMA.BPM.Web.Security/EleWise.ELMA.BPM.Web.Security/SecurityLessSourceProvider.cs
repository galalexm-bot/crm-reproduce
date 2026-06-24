using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(Order = 100)]
internal class SecurityLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.BPM.Web.Security";

	public string ContentPath => "~/Modules/EleWise.ELMA.BPM.Web.Security/Content/";

	public string FileName => "index.less";
}
