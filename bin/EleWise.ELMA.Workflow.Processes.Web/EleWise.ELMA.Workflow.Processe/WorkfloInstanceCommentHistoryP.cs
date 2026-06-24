using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Audit;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkfloInstanceCommentHistoryPartProvider : CommentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IWorkflowInstance;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData)
	{
		return eventData is IWorkflowInstanceEvent;
	}
}
