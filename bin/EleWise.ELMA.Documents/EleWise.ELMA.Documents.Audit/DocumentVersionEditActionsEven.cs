using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit.Impl;

namespace EleWise.ELMA.Documents.Audit;

[Component]
public class DocumentVersionEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return DocumentVersionActions.LockGuid;
			yield return DocumentVersionActions.UnLockGuid;
			yield return DocumentVersionActions.ChangeStatusGuid;
			yield return DocumentVersionActions.EditGuid;
			yield return DocumentVersionActions.DownloadGuid;
		}
	}
}
