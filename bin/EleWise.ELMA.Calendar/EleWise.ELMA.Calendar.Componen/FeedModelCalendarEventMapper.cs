using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component]
internal class FeedModelCalendarEventMapper : IFeedModelEntityMapper
{
	FeedModel IFeedModelEntityMapper.MapEntity(IEntity entity, FeedModel originalModel)
	{
		if (!(entity is ICalendarEvent calendarEvent))
		{
			return originalModel;
		}
		return GetParentFeedModel(calendarEvent);
	}

	internal static FeedModel GetParentFeedModel(ICalendarEvent calendarEvent)
	{
		if (calendarEvent == null)
		{
			return null;
		}
		Guid typeUid = calendarEvent.TypeUid;
		string text = string.Empty;
		if (!string.IsNullOrEmpty(calendarEvent.Subject))
		{
			text = calendarEvent.Subject;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
			{
				text = classMetadata.DisplayName;
			}
			if (string.IsNullOrEmpty(text) && InterfaceActivator.LoadMetadata<ICalendarEvent>() is ClassMetadata classMetadata2)
			{
				text = classMetadata2.DisplayName;
			}
		}
		List<string> list = new List<string>();
		if (!string.IsNullOrWhiteSpace(calendarEvent.Place))
		{
			list.Add(SR.T("Место: {0}", calendarEvent.Place));
		}
		if (!string.IsNullOrWhiteSpace(calendarEvent.Description))
		{
			list.Add(SR.T("Описание: {0}", calendarEvent.Description));
		}
		return new FeedModel
		{
			ActionObjectId = calendarEvent.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = calendarEvent.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = calendarEvent.CreationAuthor,
			CreationDate = calendarEvent.CreationDate,
			IsParent = true,
			Subject = text,
			Text = string.Join(Environment.NewLine, list),
			MessageAttachments = FeedMessageUpdateProviderBase<ICalendarEvent>.GetMessageAttachments(calendarEvent)
		};
	}
}
