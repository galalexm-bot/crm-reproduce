using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

internal sealed class WorkfloInstanceCommentAttachmentHistoryPartMerge : CommentAttachmentHistoryPartMerge
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IWorkflowInstance;
	}
}
