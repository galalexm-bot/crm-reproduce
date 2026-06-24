using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 0)]
internal class FeedModelWorkLogItemMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is IWorkLogItem workLogItem))
		{
			return originalModel;
		}
		return GetParentFeedModel(workLogItem);
	}

	internal static FeedModel GetParentFeedModel(IWorkLogItem workLogItem)
	{
		if (workLogItem == null)
		{
			return null;
		}
		Guid guid = InterfaceActivator.UID<IWorkLogItem>();
		IEntity entity = WorkLogExtensionHelper.LoadObject(workLogItem);
		string subject = ((entity == null) ? SR.T("Трудозатраты") : SR.T("Трудозатраты по: {0}", entity.ToString()));
		return new FeedModel
		{
			ActionObjectId = workLogItem.Id,
			ActionObjectUid = guid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = workLogItem.Id,
			ParentObjectUid = guid,
			ChangeDate = DateTime.Now,
			CreationAuthor = workLogItem.CreationAuthor,
			CreationDate = workLogItem.CreationDate,
			IsParent = true,
			Subject = subject,
			Text = workLogItem.Comment
		};
	}
}
