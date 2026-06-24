using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class WorkflowTaskWorkLogEntityLinkDescription : IWorkLogEntityInfoLinkDescription
{
	public bool CheckType(IEntity entity)
	{
		return entity is IWorkflowTask;
	}

	public MvcHtmlString Description(HtmlHelper htmlHelper, IEntity entity)
	{
		return PartialExtensions.Partial(htmlHelper, "WorkLogItem/WorkflowTaskInfo", (object)entity);
	}
}
