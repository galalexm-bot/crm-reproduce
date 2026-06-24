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
internal class FeedModelLeadEventMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is ILead lead))
		{
			return originalModel;
		}
		return GetParentFeedModel(lead);
	}

	internal static FeedModel GetParentFeedModel(ILead lead)
	{
		if (lead == null)
		{
			return null;
		}
		Guid guid = InterfaceActivator.UID(lead.GetType());
		string text = string.Empty;
		if (!string.IsNullOrEmpty(lead.Name))
		{
			text = lead.Name;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(guid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<ILead>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		return new FeedModel
		{
			ActionObjectId = lead.Id,
			ActionObjectUid = guid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = lead.Id,
			ParentObjectUid = guid,
			ChangeDate = DateTime.Now,
			CreationAuthor = lead.CreationAuthor,
			CreationDate = lead.CreationDate,
			IsParent = true,
			Subject = text,
			Text = lead.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<ISale>.GetMessageAttachments(lead)
		};
	}
}
