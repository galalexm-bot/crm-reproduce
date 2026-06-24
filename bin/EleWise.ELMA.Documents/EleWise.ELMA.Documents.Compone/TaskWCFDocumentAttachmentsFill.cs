using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class TaskWCFDocumentAttachmentsFiller : ITaskWCFFiller
{
	public void FillTaskWCF(ITask task, TaskWCF taskWCF)
	{
		if (task is IAttachmentsTaskBase attachmentsTaskBase)
		{
			IFileManager fileManager = Locator.GetServiceNotNull<IFileManager>();
			taskWCF.DocumentAttachments = ((attachmentsTaskBase.DocumentAttachments == null) ? new TaskDocumentAttachmentWCF[0] : (from a in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments
				where a.Document != null
				select new TaskDocumentAttachmentWCF
				{
					Id = a.Id,
					Uid = a.Uid,
					DocumentId = a.Document.Id,
					CreationAuthorId = a.CreationAuthor.Id,
					CreationDate = a.CreationDate,
					DocumentName = a.Document.Name,
					VersionId = ((a.Document.CurrentVersion != null) ? a.Document.CurrentVersion.Id : (-1)),
					VersionNumber = ((a.Document.CurrentVersion != null) ? a.Document.CurrentVersion.Version : null),
					VersionChangeDate = ((a.Document.CurrentVersion != null) ? a.Document.CurrentVersion.ChangeDate : null),
					VersionAuthorId = ((a.Document.CurrentVersion != null) ? a.Document.CurrentVersion.CreationAuthor.Id : (-1)),
					VersionContent = ((a.Document.CurrentVersion != null && a.Document.CurrentVersion.Content != null) ? a.Document.CurrentVersion.Content.ToString() : null),
					VersionFileUid = ((a.Document.CurrentVersion != null && a.Document.CurrentVersion.File != null) ? a.Document.CurrentVersion.File.Uid : Guid.Empty),
					VersionFileName = ((a.Document.CurrentVersion != null && a.Document.CurrentVersion.File != null) ? a.Document.CurrentVersion.File.Name : null),
					VersionFileSize = ((a.Document.CurrentVersion != null && a.Document.CurrentVersion.File != null) ? fileManager.FileSize(a.Document.CurrentVersion.File.Id) : (-1))
				}).ToArray());
		}
	}
}
