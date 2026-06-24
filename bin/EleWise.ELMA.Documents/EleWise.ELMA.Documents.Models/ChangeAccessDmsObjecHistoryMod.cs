using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class ChangeAccessDmsObjecHistoryModel : HistoryBaseModel, IEditedHistoryModel<IDmsObject>, IHistoryBaseModel, IDocumentHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDmsObject OldEntity { get; set; }

	public IDmsObject NewEntity { get; set; }

	public DmsObjectPermissionsInfo Info { get; set; }

	public ChangeAccessDmsObjecHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
