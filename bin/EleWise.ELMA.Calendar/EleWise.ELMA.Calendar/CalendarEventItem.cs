using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar;

[Serializable]
public class CalendarEventItem : ICalendarItem
{
	[ScriptIgnore]
	public readonly ICalendarEvent Event;

	[ScriptIgnore]
	public IUser CurrentUser { get; set; }

	public string Id => Event.Id.ToString();

	public Guid Uid => Event.Uid;

	public string SourceId => string.Empty;

	public Guid SourceTypeUid => InterfaceActivator.UID<ICalendarEvent>();

	public bool OnlyInfo { get; set; }

	public long CreationAuthor { get; set; }

	public bool ReadOnly { get; set; }

	public bool MarkExpired => false;

	public bool ToInform
	{
		get
		{
			if (CurrentUser == null)
			{
				return false;
			}
			CalendarEventUserStatus[] source = (from s in (IEnumerable<ICalendarEventUser>)Event.EventUsers
				where s.User == CurrentUser
				select s.Status).ToArray();
			return source.Contains(CalendarEventUserStatus.InfromTo) && !source.Contains(CalendarEventUserStatus.Participant);
		}
	}

	public DateTime StartDate
	{
		get
		{
			return Event.StartDate;
		}
		set
		{
			Event.StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return Event.EndDate;
		}
		set
		{
			Event.EndDate = value;
		}
	}

	public bool Completed
	{
		get
		{
			return Event.Completed;
		}
		set
		{
			Event.Completed = value;
		}
	}

	public string Theme
	{
		get
		{
			return Event.Subject;
		}
		set
		{
			Event.Subject = value;
		}
	}

	public string Place
	{
		get
		{
			return PrivateAccess ? null : Event.Place;
		}
		set
		{
			Event.Place = value;
		}
	}

	public string To { get; set; }

	public IDictionary<string, string> EventUsers { get; set; }

	public string Description
	{
		get
		{
			return PrivateAccess ? null : Event.Description;
		}
		set
		{
			Event.Description = value;
		}
	}

	public bool HasCopy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ICollection<IComment> Comments => (ICollection<IComment>)Event.Comments;

	public bool PrivateAccess
	{
		get
		{
			CalendarSettingsModule serviceNotNull = Locator.GetServiceNotNull<CalendarSettingsModule>();
			bool flag = false;
			if (serviceNotNull.Settings != null)
			{
				flag = serviceNotNull.Settings.EnablePrivateMode;
			}
			bool flag2 = Event.IsPrivate && !((IEnumerable<ICalendarEventUser>)Event.EventUsers).Any((ICalendarEventUser eu) => eu.Status == CalendarEventUserStatus.Participant && eu.User == CurrentUser);
			return flag && flag2;
		}
	}

	public CalendarEventItem(ICalendarEvent @event, IUser currentUser = null)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		Event = @event;
		CurrentUser = currentUser;
		EventUsers = (PrivateAccess ? new Dictionary<string, string>() : ((IEnumerable<ICalendarEventUser>)Event.EventUsers).Distinct((ICalendarEventUser a, ICalendarEventUser b) => a.User.Id == b.User.Id, (ICalendarEventUser c) => c.User.Id.GetHashCode()).ToDictionary((ICalendarEventUser u) => u.User.Id.ToString(), (ICalendarEventUser u) => u.User.GetShortName()));
		CreationAuthor = Event.CreationAuthor.Id;
		ReadOnly = false;
	}

	public ICalendarItem Clone()
	{
		return new CalendarEventItem(Event, CurrentUser);
	}
}
