using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Helpers;

public static class FeedSetReadHelper
{
	public static void SetAsReadForObject(IEntity entity, long? recipientId = null)
	{
		long objectId;
		try
		{
			objectId = Convert.ToInt64(entity.GetId());
		}
		catch (Exception)
		{
			return;
		}
		SetAsReadForObject(InterfaceActivator.UID(entity.CastAsRealType().GetType()), objectId, recipientId);
	}

	public static void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null)
	{
		IEnumerable<IFeedSetReadProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFeedSetReadProvider>();
		if (extensionPoints == null)
		{
			return;
		}
		foreach (IFeedSetReadProvider item in extensionPoints)
		{
			item.SetAsReadForObject(objectUid, objectId, recipientId);
		}
	}
}
