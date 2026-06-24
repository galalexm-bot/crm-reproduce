using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component]
internal class FeedModelUserMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is IUser user))
		{
			return originalModel;
		}
		return GetParentFeedModel(user);
	}

	internal static FeedModel GetParentFeedModel(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		Guid guid = InterfaceActivator.UID(user.GetType());
		string text = string.Empty;
		string shortName = user.GetShortName();
		if (!string.IsNullOrEmpty(shortName))
		{
			text = shortName;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(guid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = SR.T("Пользователь");
			}
		}
		string positions = user.GetPositions();
		FeedModel feedModel = new FeedModel();
		feedModel.ActionObjectId = user.Id;
		feedModel.ActionObjectUid = guid;
		feedModel.ActionUid = DefaultEntityActions.CreateGuid;
		feedModel.ParentObjectId = user.Id;
		feedModel.ParentObjectUid = guid;
		feedModel.ChangeDate = DateTime.Now;
		feedModel.CreationAuthor = user;
		feedModel.CreationDate = (user.EmployDate.HasValue ? user.EmployDate.Value : DateTime.Now);
		feedModel.IsParent = true;
		feedModel.Subject = text;
		feedModel.Text = ((!string.IsNullOrEmpty(positions)) ? SR.T("Должность: {0}", user.GetPositions()) : null);
		feedModel.MessageAttachments = FeedMessageUpdateProviderBase<IUser>.GetMessageAttachments(user);
		return feedModel;
	}
}
