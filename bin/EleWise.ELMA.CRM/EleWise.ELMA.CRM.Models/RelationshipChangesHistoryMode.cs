using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

public class RelationshipChangesHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<IRelationship>, IRelationshipHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IRelationship OldEntity { get; set; }

	public IRelationship NewEntity { get; set; }

	public IList<IUser> OldEventUsers { get; set; }

	public IList<IUser> NewEventUsers { get; set; }

	public List<Guid> BaseProperties => RelationshipActionHelper.BaseProperties();

	public RelationshipChangesHistoryModel(EntityActionEventArgs originalRelationship, string actionTheme)
		: base(originalRelationship, actionTheme)
	{
	}
}
