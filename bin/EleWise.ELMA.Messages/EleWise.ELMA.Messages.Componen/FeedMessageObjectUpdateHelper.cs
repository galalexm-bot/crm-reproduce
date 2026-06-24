using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components;

public static class FeedMessageObjectUpdateHelper
{
	public static void UpdateMessageObjectInfo(IEntity entity, Guid actionUid, bool afterCommit = false)
	{
		if (entity == null || entity.GetId() == null)
		{
			return;
		}
		long objectId;
		try
		{
			objectId = Convert.ToInt64(entity.GetId());
		}
		catch (Exception)
		{
			return;
		}
		FeedMessageInfoParameters info = new FeedMessageInfoParameters
		{
			ActionUid = actionUid,
			ObjectId = objectId,
			ObjectUid = InterfaceActivator.UID(entity.GetType()),
			Recipients = new List<long>()
		};
		List<IFeedMessageGetData> source = (from m in ComponentManager.Current.GetExtensionPoints<IFeedMessageGetData>()
			where m.IsSupport(info.ObjectUid, info.ActionUid)
			select m).ToList();
		if (!source.Any())
		{
			return;
		}
		foreach (List<long> item in from extension in source
			select extension.GetRecipients(entity, actionUid) into m
			where m?.Any() ?? false
			select m)
		{
			info.Recipients.AddRange(item);
		}
		if (!info.Recipients.Any())
		{
			return;
		}
		info.Recipients = info.Recipients.Distinct().ToList();
		if (afterCommit)
		{
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RegisterPostCommitAction(delegate
			{
				FeedManager.Instance.AddMessageInfo(info);
			});
		}
		else
		{
			FeedManager.Instance.AddMessageInfo(info);
		}
	}
}
