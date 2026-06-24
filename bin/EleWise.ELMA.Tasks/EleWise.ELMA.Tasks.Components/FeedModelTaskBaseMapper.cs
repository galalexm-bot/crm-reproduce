using System;
using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 0)]
internal class FeedModelTaskBaseMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is ITaskBase task))
		{
			return originalModel;
		}
		return GetParentFeedModel(task);
	}

	internal static FeedModel GetParentFeedModel(ITaskBase task)
	{
		if (task == null)
		{
			return null;
		}
		Guid typeUid = task.TypeUid;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(task.Subject))
		{
			text = task.Subject;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = SR.T("Задача");
			}
		}
		List<MessageObject> list = new List<MessageObject>();
		foreach (IWatch watch in WatchManager.Instance.GetWatches(task.TypeUid, task.Id, onlyForEntity: true, excludeExtensions: false))
		{
			list.Add(new MessageObject
			{
				Id = watch.User.Id.ToString(CultureInfo.InvariantCulture),
				TypeUid = InterfaceActivator.UID<IWatch>(),
				Name = watch.User.GetShortName()
			});
		}
		return new FeedModel
		{
			ActionObjectId = task.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = task.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = task.CreationAuthor,
			CreationDate = (task.CreationDate.HasValue ? task.CreationDate.Value : DateTime.Now),
			IsParent = true,
			Subject = text,
			Text = task.Description,
			MessageAttachments = FeedMessageUpdateProviderBase<ITaskBase>.GetMessageAttachments(task),
			MessageObjects = new FeedMessageObjectList(list)
		};
	}
}
