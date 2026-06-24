using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Models;

public class UserEditDocumentVersionHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, IEditedHistoryModel<IDocumentVersion>, IDocumentHistoryBaseModel
{
	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDocumentVersion OldEntity { get; set; }

	public IDocumentVersion NewEntity { get; set; }

	public List<Guid> HiddenProperties
	{
		get
		{
			List<Guid> list = new List<Guid>();
			list.Add(InterfaceActivator.PropertyUid((IDocumentVersion m) => m.Salt));
			return list;
		}
	}

	public UserEditDocumentVersionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
