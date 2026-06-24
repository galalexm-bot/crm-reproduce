using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.Components;

internal class CalendarEventActionHelper
{
	private static List<Guid> baseProperties;

	public static List<Guid> BaseProperties()
	{
		if (baseProperties == null)
		{
			baseProperties = (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<ICalendarEvent>())).Properties
				where !p.ViewSettings.GetForView(ViewType.Edit).Visible && (p.Name == "ChangeDate" || p.Name == "ChangeAuthor" || p.Name == "EventUsersHash")
				select p.Uid).ToList();
		}
		return baseProperties;
	}
}
