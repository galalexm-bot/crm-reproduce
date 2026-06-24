using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Services;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

[Component]
public class WorkflowTaskStatusLinkDescription : ITaskStatusLinkDescription
{
	private IDocumentRouteTaskExecutorStatusLinkDescription documentRouteTaskExecutorStatusLinkDescription;

	private IDocumentRouteTaskExecutorStatusLinkDescription DocumentRouteTaskExecutorStatusLinkDescription => documentRouteTaskExecutorStatusLinkDescription ?? (documentRouteTaskExecutorStatusLinkDescription = Locator.GetServiceNotNull<IDocumentRouteTaskExecutorStatusLinkDescription>());

	public bool CheckType(ITaskBase task)
	{
		return task is IWorkflowTask;
	}

	public MvcHtmlString Description(HtmlHelper htmlHelper, ITaskBase task)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (task == null)
		{
			return null;
		}
		if (DocumentRouteTaskExecutorStatusLinkDescription.IsDocumentRoutesInfo(htmlHelper.get_ViewData().get_Model()))
		{
			return new MvcHtmlString(string.Format("({0})", PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.Executor)));
		}
		bool? flag = (bool?)htmlHelper.get_ViewData().get_Item("isCardForm");
		if (flag.HasValue && flag.Value)
		{
			return PartialExtensions.Partial(htmlHelper, "WorkflowTaskDescription", (object)(IWorkflowTask)task);
		}
		return MvcHtmlString.Empty;
	}
}
