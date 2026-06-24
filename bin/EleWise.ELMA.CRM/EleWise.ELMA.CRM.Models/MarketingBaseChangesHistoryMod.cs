using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class MarketingBaseChangesHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<IMarketingBase>, IMarketingBaseHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IMarketingBase OldEntity { get; set; }

	public IMarketingBase NewEntity { get; set; }

	public List<Guid> BaseProperties => MarketingBaseActionHelper.BaseProperties();

	public MarketingBaseChangesHistoryModel(EntityActionEventArgs originalMarketingBase, string actionTheme)
		: base(originalMarketingBase, actionTheme)
	{
	}
}
