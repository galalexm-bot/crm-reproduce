using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Models;

public class UserEditDocumentHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, IEditedHistoryModel<IDocument>, IDocumentHistoryBaseModel
{
	private Lazy<List<Guid>> _baseProperties;

	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IDocument OldEntity { get; set; }

	public IDocument NewEntity { get; set; }

	public List<Guid> BaseProperties
	{
		get
		{
			if (_baseProperties == null)
			{
				_baseProperties = new Lazy<List<Guid>>(() => (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IDocument>())).Properties
					where p.Name != "Name" && p.Name != "Description"
					select p.Uid).ToList());
			}
			return _baseProperties.Value;
		}
	}

	public UserEditDocumentHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
		ChangedProperties = new List<PropertyMetadata>();
	}
}
