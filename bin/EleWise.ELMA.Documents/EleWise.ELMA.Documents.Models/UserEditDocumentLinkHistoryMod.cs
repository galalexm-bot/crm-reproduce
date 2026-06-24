using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class UserEditDocumentLinkHistoryModel : HistoryBaseModel, IEditedHistoryModel<IDocumentLink>, IHistoryBaseModel, IDocumentHistoryBaseModel
{
	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDocumentLink OldEntity { get; set; }

	public IDocumentLink NewEntity { get; set; }

	public UserEditDocumentLinkHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
