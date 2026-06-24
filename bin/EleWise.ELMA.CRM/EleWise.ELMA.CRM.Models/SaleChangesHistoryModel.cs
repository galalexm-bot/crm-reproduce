using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class SaleChangesHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<ISale>, ISaleHistoryBaseModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ISale OldEntity { get; set; }

	public ISale NewEntity { get; set; }

	public List<Guid> BaseProperties => SaleActionHelper.BaseProperties();

	public SaleChangesHistoryModel(EntityActionEventArgs originalSale, string actionTheme)
		: base(originalSale, actionTheme)
	{
	}
}
