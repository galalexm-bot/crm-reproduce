using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class UnLockDocumentVersionHistoryModel : HistoryBaseModel, IEditedHistoryModel<IDocumentVersion>, IHistoryBaseModel, IDocumentHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDocumentVersion OldEntity { get; set; }

	public IDocumentVersion NewEntity { get; set; }

	public UnLockDocumentVersionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
