using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
internal class WorkflowLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public string Area => "EleWise.ELMA.Workflow.Web";

	public string ContentPath => "~/Modules/EleWise.ELMA.Workflow.Web/Content/";

	public string FileName => "index.less";
}
