using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component(Order = 300)]
internal class CalendarLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.BPM.Web.Calendar";

	public string ContentPath => "~/Modules/EleWise.ELMA.BPM.Web.Calendar/Content/";

	public string FileName => "index.less";
}
