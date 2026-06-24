using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Components.Feed;

[Component]
internal class FeedModelRelationshipEventMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is IRelationship relationship))
		{
			return originalModel;
		}
		return GetParentFeedModel(relationship);
	}

	internal static FeedModel GetParentFeedModel(IRelationship relationship)
	{
		if (relationship == null)
		{
			return null;
		}
		Guid typeUid = relationship.TypeUid;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(relationship.Theme))
		{
			text = relationship.Theme;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<IRelationship>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		return new FeedModel
		{
			ActionObjectId = relationship.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = relationship.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = relationship.CreationAuthor,
			CreationDate = (relationship.CreationDate.HasValue ? relationship.CreationDate.Value : DateTime.Now),
			IsParent = true,
			Subject = text,
			Text = relationship.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<IRelationship>.GetMessageAttachments(relationship)
		};
	}
}
