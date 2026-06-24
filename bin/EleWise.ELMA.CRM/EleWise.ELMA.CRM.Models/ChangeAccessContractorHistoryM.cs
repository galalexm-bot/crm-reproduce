using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Audit;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class ChangeAccessContractorHistoryModel : HistoryBaseModel, IEditedHistoryModel<IContractor>, IHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IContractor OldEntity { get; set; }

	public IContractor NewEntity { get; set; }

	public CrmPermissionsInfo Info { get; set; }

	public ChangeAccessContractorHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
