using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

internal class TaskCommentAttachmentHistoryPartMerge : CommentAttachmentHistoryPartMerge
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ITaskBase;
	}
}
