using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

public class SignDocumentVersionHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IDocumentAttachedHistoryModel, IAttachedHistoryModel, IEditedHistoryModel<IDocumentVersion>, IDocumentHistoryBaseModel
{
	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public ICollection<IDocumentAttachment> DocumentAttachments { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDocumentVersion OldEntity { get; set; }

	public IDocumentVersion NewEntity { get; set; }

	public SignDocumentVersionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
		OldEntity = originalEvent.Old as IDocumentVersion;
		NewEntity = originalEvent.New as IDocumentVersion;
	}
}
