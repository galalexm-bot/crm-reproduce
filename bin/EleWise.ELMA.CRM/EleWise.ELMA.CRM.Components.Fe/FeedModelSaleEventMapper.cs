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
internal class FeedModelSaleEventMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is ISale sale))
		{
			return originalModel;
		}
		return GetParentFeedModel(sale);
	}

	internal static FeedModel GetParentFeedModel(ISale sale)
	{
		if (sale == null)
		{
			return null;
		}
		Guid guid = InterfaceActivator.UID(sale.GetType());
		string text = string.Empty;
		if (!string.IsNullOrEmpty(sale.Name))
		{
			text = sale.Name;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(guid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<ISale>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		return new FeedModel
		{
			ActionObjectId = sale.Id,
			ActionObjectUid = guid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = sale.Id,
			ParentObjectUid = guid,
			ChangeDate = DateTime.Now,
			CreationAuthor = sale.Author,
			CreationDate = sale.CreationDate,
			IsParent = true,
			Subject = text,
			Text = sale.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<ISale>.GetMessageAttachments(sale)
		};
	}
}
