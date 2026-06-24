using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class LeadChangesHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<ILead>, ILeadHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ILead OldEntity { get; set; }

	public ILead NewEntity { get; set; }

	public LeadChangesHistoryModel(EntityActionEventArgs originalLead, string actionTheme)
		: base(originalLead, actionTheme)
	{
	}
}
