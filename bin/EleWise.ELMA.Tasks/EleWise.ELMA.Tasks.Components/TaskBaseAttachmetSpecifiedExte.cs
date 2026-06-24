using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 10)]
internal sealed class TaskBaseAttachmetSpecifiedExtension : ITaskAttachmetSpecifiedHistoryExtension, ITaskAttachmetSpecifiedExtension
{
	private AttachmentManager attachmentManager;

	public string Name => "Attachments";

	public TaskBaseAttachmetSpecifiedExtension(AttachmentManager attachmentManager)
	{
		this.attachmentManager = attachmentManager;
	}

	public IEnumerable<long> AttachmentsIds(ITaskBase task)
	{
		if (!task.AttachmentsSpecified.IsInitialized<IAttachment>())
		{
			return new List<long>();
		}
		return ((IEnumerable<IAttachment>)task.AttachmentsSpecified).Select((IAttachment t) => t.Id);
	}

	public bool AttachmentsIdsInitialized(ITaskBase task)
	{
		return task.AttachmentsSpecified.IsInitialized<IAttachment>();
	}

	public IEnumerable<IEntity<long>> GetAttachments(IEnumerable<long> ids)
	{
		return attachmentManager.FindByIdArray(ids.ToArray());
	}

	public void SaveAttachments(ITaskBase task)
	{
		if (task == null)
		{
			return;
		}
		foreach (IAttachment item in (IEnumerable<IAttachment>)task.AttachmentsSpecified)
		{
			if (item != null && item.Id != 0L)
			{
				item.Save();
			}
		}
	}
}
