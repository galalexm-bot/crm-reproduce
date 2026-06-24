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
internal class FeedModelContractorEventMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is IContractor contractor))
		{
			return originalModel;
		}
		return GetParentFeedModel(contractor);
	}

	internal static FeedModel GetParentFeedModel(IContractor contractor)
	{
		if (contractor == null)
		{
			return null;
		}
		Guid typeUid = contractor.TypeUid;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(contractor.Name))
		{
			text = contractor.Name;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<IContractor>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		return new FeedModel
		{
			ActionObjectId = contractor.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = contractor.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = contractor.CreationAuthor,
			CreationDate = (contractor.CreationDate.HasValue ? contractor.CreationDate.Value : DateTime.Now),
			IsParent = true,
			Subject = text,
			Text = contractor.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<IContractor>.GetMessageAttachments(contractor)
		};
	}
}
