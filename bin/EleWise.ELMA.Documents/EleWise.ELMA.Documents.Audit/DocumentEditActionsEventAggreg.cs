using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit.Impl;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal class DocumentEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	protected override IEnumerable<Guid> ProcessedActions
	{
		get
		{
			yield return DocumentActions.ChangeStatusGuid;
			yield return DmsObjectActions.EditGuid;
			yield return DmsObjectActions.ChangeAccessGuid;
			yield return DocumentActions.ConvertedFromOtherTypeGuid;
		}
	}
}
