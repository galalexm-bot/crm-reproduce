using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 20)]
internal sealed class TaskBaseDocumentAttachmetSpecifiedExtension : ITaskAttachmetSpecifiedHistoryExtension, ITaskAttachmetSpecifiedExtension
{
	private DocumentAttachmentManager documentAttachmentManager;

	public string Name => "DocAttachments";

	public TaskBaseDocumentAttachmetSpecifiedExtension(DocumentAttachmentManager documentAttachmentManager)
	{
		this.documentAttachmentManager = documentAttachmentManager;
	}

	public IEnumerable<long> AttachmentsIds(ITaskBase task)
	{
		if (!(task as IAttachmentsTaskBase).DocumentAttachmentsSpecified.IsInitialized<IDocumentAttachment>())
		{
			return new List<long>();
		}
		return ((IEnumerable<IDocumentAttachment>)((IAttachmentsTaskBase)task).DocumentAttachmentsSpecified).Select((IDocumentAttachment t) => t.Id);
	}

	public bool AttachmentsIdsInitialized(ITaskBase task)
	{
		return (task as IAttachmentsTaskBase).DocumentAttachmentsSpecified.IsInitialized<IDocumentAttachment>();
	}

	public IEnumerable<IEntity<long>> GetAttachments(IEnumerable<long> ids)
	{
		return documentAttachmentManager.FindByIdArray(ids.ToArray());
	}

	public void SaveAttachments(ITaskBase task)
	{
		if (!(task is IAttachmentsTaskBase attachmentsTaskBase))
		{
			return;
		}
		foreach (IDocumentAttachment item in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified)
		{
			if (item != null && item.Id != 0L)
			{
				item.Save();
			}
		}
	}
}
