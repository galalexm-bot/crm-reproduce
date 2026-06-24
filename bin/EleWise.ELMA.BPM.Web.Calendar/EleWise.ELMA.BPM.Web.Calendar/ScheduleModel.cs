using System;
using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class ScheduleModel : EntityModel<ISchedule>
{
	public static string DefaultId = "FullCalendar";

	private ScheduleState _state;

	public string CalendarId { get; set; }

	public ScheduleState State
	{
		get
		{
			if (_state == null)
			{
				try
				{
					_state = StateExtensions.LoadState<ScheduleState>("/calendar/" + CalendarId);
				}
				catch (Exception exception)
				{
					Logger.Log.Error(SR.T("Ошибка загрузки состояния календаря"), exception);
				}
				if (_state == null)
				{
					_state = new ScheduleState
					{
						Id = "/calendar/" + CalendarId,
						ListView = false,
						Mode = ScheduleMode.Day,
						ViewDate = DateTime.Now
					};
				}
			}
			return _state;
		}
	}

	public ISchedule CurrentUserSchedule { get; set; }

	public bool ShowSharedSchedulesPopup { get; set; }

	public List<ISchedule> CommonSchedules { get; set; }

	public List<ISchedule> UserSchedules { get; set; }

	public List<ISchedule> BlockUserSchedules { get; set; }

	public List<CalendarItemModel<ICalendarItem>> Events { get; set; }

	public List<IEventAddAction> AddActions { get; set; }

	public CalendarItemModel<ICalendarPlannedItem> SelectedItem { get; set; }

	public bool ShowExpired { get; set; }

	public bool ForList { get; set; }

	public IUser CurrentUser { get; set; }

	public DateTime CurrentDate { get; set; }

	public bool ShowRightPanel
	{
		get
		{
			if (base.Entity != null && base.Entity.Owner == CurrentUser)
			{
				return !InPopup;
			}
			return false;
		}
	}

	public bool ShowPermissionButton { get; set; }

	public bool Editable { get; set; }

	public bool IsFavorite { get; set; }

	public bool InPopup { get; set; }

	public string CalendarTitle { get; set; }

	public int RefetchEventsTimeout { get; set; }

	public string CalendarName
	{
		get
		{
			if (base.Entity == null || (base.Entity.Owner != null && base.Entity.Owner == CurrentUser))
			{
				return string.Empty;
			}
			return base.Entity.Name;
		}
	}

	public List<string> HoursList
	{
		get
		{
			List<string> list = new List<string>();
			bool flag = CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern.Contains("tt");
			bool flag2 = CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern.Contains("h");
			for (int i = 0; i < 24; i++)
			{
				string item = (flag2 ? ((i + 11) % 12 + 1) : i) + "<sup>00</sup>" + (flag ? ((i < 12) ? ("<sup>" + CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator + "</sup>") : ("<sup>" + CultureInfo.CurrentCulture.DateTimeFormat.PMDesignator + "</sup>")) : "");
				list.Add(item);
			}
			return list;
		}
	}

	public string LastColumn { get; set; }

	public ScheduleModel(ISchedule model)
		: base(model)
	{
		InitCollections();
	}

	public ScheduleModel()
	{
		InitCollections();
	}

	private void InitCollections()
	{
		CalendarId = DefaultId;
		Events = new List<CalendarItemModel<ICalendarItem>>();
		AddActions = new List<IEventAddAction>();
		CommonSchedules = new List<ISchedule>();
		UserSchedules = new List<ISchedule>();
		BlockUserSchedules = new List<ISchedule>();
	}
}
