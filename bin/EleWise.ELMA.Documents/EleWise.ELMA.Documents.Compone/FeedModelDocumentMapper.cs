using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component]
internal class FeedModelDocumentMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is IDocument document))
		{
			return originalModel;
		}
		return GetParentFeedModel(document);
	}

	internal static FeedModel GetParentFeedModel(IDocument document)
	{
		if (document == null)
		{
			return null;
		}
		Guid typeUid = document.TypeUid;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(document.Name))
		{
			text = document.Name;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<IDocument>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		return new FeedModel
		{
			ActionObjectId = document.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = document.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = document.CreationAuthor,
			CreationDate = (document.CreationDate ?? DateTime.Now),
			IsParent = true,
			Subject = text,
			Text = document.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<IDocument>.GetMessageAttachments(document)
		};
	}
}
