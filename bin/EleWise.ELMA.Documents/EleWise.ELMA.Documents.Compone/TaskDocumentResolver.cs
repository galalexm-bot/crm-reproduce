using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal class TaskDocumentResolver : ObjectDocumentResolverBase
{
	public AttachmentsTaskBaseManager AttachmentsTaskBaseManager { get; set; }

	public override bool CheckType(IEntity entity)
	{
		return entity is ITaskBase;
	}

	public override IEnumerable<IDocument> Resolve(IEntity entity)
	{
		return AttachmentsTaskBaseManager.GetDocumentsFromTask(entity as IAttachmentsTaskBase);
	}
}
