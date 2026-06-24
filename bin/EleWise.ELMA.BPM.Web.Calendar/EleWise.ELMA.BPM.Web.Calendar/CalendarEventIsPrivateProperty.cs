using System;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
public class CalendarEventIsPrivatePropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((ICalendarEvent m) => m.IsPrivate);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			ICalendarEvent obj = model as ICalendarEvent;
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			CalendarSettings settings = Locator.GetServiceNotNull<CalendarSettingsModule>().Settings;
			if (obj != null && (settings == null || !settings.EnablePrivateMode) && formViewItem.IsUid(new Guid("6ee3d50e-9db4-4359-987b-51c8afd3c734")))
			{
				propertyViewItem.Hide = true;
			}
		}
	}
}
