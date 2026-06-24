using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class SlaveActionContractorHistoryModel : HistoryBaseModel, IEditedHistoryModel<IContractor>, IHistoryBaseModel, IContractorHistoryBaseModel
{
	public IContractor OldEntity { get; set; }

	public IContractor NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ReferenceOnEntity SlaveObject { get; set; }

	public Guid ActionUid { get; set; }

	public SlaveActionContractorHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
