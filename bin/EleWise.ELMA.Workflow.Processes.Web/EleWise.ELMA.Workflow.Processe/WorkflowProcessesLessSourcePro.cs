using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(Order = 800)]
internal class WorkflowProcessesLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.Workflow.Processes.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.Workflow.Processes.Web/Content/";

	public string FileName => "index.less";
}
