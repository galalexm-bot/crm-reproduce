using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Audit.HistoryModels;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
internal class WorkflowInstanceAttachmentHistoryPartProvider : AttachmentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IWorkflowInstance;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IAttachedHistoryModel eventData)
	{
		return eventData is AddCommentWorkflowInstanceHistoryModel;
	}
}
