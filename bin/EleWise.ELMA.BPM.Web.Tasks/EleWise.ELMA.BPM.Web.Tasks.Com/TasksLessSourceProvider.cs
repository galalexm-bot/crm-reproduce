using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 500)]
internal class TasksLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.BPM.Web.Tasks";

	public string ContentPath => "~/Modules/EleWise.ELMA.BPM.Web.Tasks/Content/";

	public string FileName => "index.less";
}
