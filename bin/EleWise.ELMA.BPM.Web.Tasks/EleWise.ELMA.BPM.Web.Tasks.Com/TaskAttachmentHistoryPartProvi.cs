using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TaskAttachmentHistoryPartProvider : AttachmentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is ITaskBase;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, IAttachedHistoryModel eventData)
	{
		return eventData is ITaskHistoryBaseModel;
	}
}
