using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CalendarEventModel : DynamicEntityViewModel<ICalendarEvent>
{
	private IEnumerable<CheckBoxListItem> _schdulesList;

	private ICollection<IUser> _informUsers;

	private ICollection<IUser> _partyUsers;

	public bool EnablePrivateMode
	{
		get
		{
			CalendarSettingsModule serviceNotNull = Locator.GetServiceNotNull<CalendarSettingsModule>();
			bool result = false;
			if (serviceNotNull.Settings != null)
			{
				result = serviceNotNull.Settings.EnablePrivateMode;
			}
			return result;
		}
	}

	public bool PrivateAccess
	{
		get
		{
			if (!CurrentIsAuthor && base.Entity.IsPrivate)
			{
				return !PartyUsers.Contains(CurrentUser);
			}
			return false;
		}
	}

	public DateTime OldStartDate { get; set; }

	public DateTime OldEndDate { get; set; }

	public bool OldConfirmParticipation { get; set; }

	public IUser CurrentUser { get; set; }

	public Periodicity? OldPeriod { get; set; }

	public Periodicity? Period { get; set; }

	public bool StopRepeat { get; set; }

	public ICollection<ISchedule> AllowSchedules { get; set; }

	public long[] Schedules { get; set; }

	public bool ShowInformTo
	{
		get
		{
			if (!((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Any((ICalendarEventUser u) => u.Status == CalendarEventUserStatus.InfromTo))
			{
				return base.Entity.IsNew();
			}
			return true;
		}
	}

	public bool ShowSchedules => ((IEnumerable<ISchedule>)base.Entity.Schedules).Any();

	public bool ShowPeriod => Period.HasValue;

	public bool ShowConfirmParticipation { get; set; }

	public bool ShowNotConfirmParticipation { get; set; }

	public bool AllowConfirmParticipation => !Period.HasValue;

	public bool CanEdit { get; set; }

	public bool CanEditAll { get; set; }

	public bool CurrentIsAuthor => CurrentUser == base.Entity.CreationAuthor;

	public bool IsPeriodical
	{
		get
		{
			try
			{
				return (base.Entity.TemplateEvent != null && base.Entity.TemplateEvent.Id > -1) || base.Entity is ICalendarEventPeriodical;
			}
			catch
			{
				return false;
			}
		}
	}

	public ICalendarEventPeriodical PeriodicalEntity
	{
		get
		{
			if (!(base.Entity is ICalendarEventPeriodical))
			{
				return null;
			}
			return (ICalendarEventPeriodical)base.Entity;
		}
	}

	public string PeriodicalEntitySettings { get; set; }

	public string OldPeriodicalEntitySettings { get; set; }

	public IComment Comment { get; set; }

	public ICollection<IUser> InformUsers
	{
		get
		{
			if (base.Entity != null)
			{
				return (from s in (IEnumerable<ICalendarEventUser>)base.Entity.EventUsers
					where s.Status == CalendarEventUserStatus.InfromTo
					select s into u
					select u.User).ToList();
			}
			return new List<IUser>();
		}
		set
		{
			_informUsers = value;
		}
	}

	[Required(true)]
	[RequiredField]
	public ICollection<IUser> PartyUsers
	{
		get
		{
			if (base.Entity != null)
			{
				return (from s in (IEnumerable<ICalendarEventUser>)base.Entity.EventUsers
					where s.Status == CalendarEventUserStatus.Participant
					select s into u
					select u.User).ToList();
			}
			return new List<IUser>();
		}
		set
		{
			_partyUsers = value;
		}
	}

	public IEnumerable<CheckBoxListItem> SchedulesList
	{
		get
		{
			if (_schdulesList == null)
			{
				if (AllowSchedules == null || AllowSchedules.Count == 0 || base.Entity == null)
				{
					_schdulesList = new List<CheckBoxListItem>();
				}
				else
				{
					_schdulesList = AllowSchedules.Select((ISchedule s) => new CheckBoxListItem(s.Id.ToString(), s.Name, ((IEnumerable<ISchedule>)base.Entity.Schedules).Any((ISchedule e) => e.Id == s.Id))
					{
						Description = s.Description
					});
				}
			}
			return _schdulesList;
		}
	}

	public CalendarEventModel()
	{
	}

	public CalendarEventModel(ICalendarEvent evnt)
		: this(evnt, ViewType.Create)
	{
	}

	public CalendarEventModel(ICalendarEvent evnt, ViewType viewType)
		: base(evnt, viewType)
	{
		StopRepeat = PeriodicalEntity != null && PeriodicalEntity.UntilDate.HasValue && !PeriodicalEntity.UntilDate.Value.EqualsUpToMinute(DateTime.MaxValue);
		OldStartDate = evnt.StartDate;
		OldEndDate = evnt.EndDate;
		OldConfirmParticipation = evnt.ConfirmParticipation;
		if (PeriodicalEntity != null && !PeriodicalEntity.IsNew())
		{
			Period = PeriodicalEntity.Period;
			OldPeriod = PeriodicalEntity.Period;
			PeriodicalEntitySettings = PeriodicalEntity.GetSerializedPeriodicalEntitySettings();
			OldPeriodicalEntitySettings = PeriodicalEntitySettings;
		}
	}

	public void BindSchedules(ICollection<ISchedule> allow)
	{
		((ICollection<ISchedule>)base.Entity.Schedules).Clear();
		if (Schedules == null || !Schedules.Any())
		{
			return;
		}
		int i;
		for (i = 0; i < Schedules.Count(); i++)
		{
			if (allow.Any((ISchedule s) => s.Id == Schedules[i]))
			{
				base.Entity.Schedules.Add(allow.First((ISchedule s) => s.Id == Schedules[i]));
			}
		}
	}

	public void ApplyUsers()
	{
		if (base.Entity == null)
		{
			return;
		}
		if (base.Entity.EventUsers == null)
		{
			base.Entity.EventUsers = (ISet<ICalendarEventUser>)(object)new HashedSet<ICalendarEventUser>();
		}
		else if (((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Any())
		{
			List<ICalendarEventUser> list = ((_informUsers != null && _informUsers.Any()) ? (from eu in (IEnumerable<ICalendarEventUser>)base.Entity.EventUsers
				where eu.Status == CalendarEventUserStatus.InfromTo
				where !_informUsers.Contains(eu.User)
				select eu).ToList() : new List<ICalendarEventUser>(((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Where((ICalendarEventUser eu) => eu.Status == CalendarEventUserStatus.InfromTo).ToList()));
			if (list.Any())
			{
				base.Entity.EventUsers.RemoveAll((ICollection<ICalendarEventUser>)list);
			}
			List<ICalendarEventUser> list2 = ((_partyUsers != null && _partyUsers.Any()) ? (from eu in (IEnumerable<ICalendarEventUser>)base.Entity.EventUsers
				where eu.Status == CalendarEventUserStatus.Participant
				where !_partyUsers.Contains(eu.User)
				select eu).ToList() : new List<ICalendarEventUser>(((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Where((ICalendarEventUser eu) => eu.Status == CalendarEventUserStatus.Participant).ToList()));
			if (list2.Any())
			{
				base.Entity.EventUsers.RemoveAll((ICollection<ICalendarEventUser>)list2);
			}
		}
		if (_informUsers != null && _informUsers.Count > 0)
		{
			foreach (IUser informUser in _informUsers)
			{
				if (informUser != null && !((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Any((ICalendarEventUser u) => u.User == informUser && u.Status == CalendarEventUserStatus.InfromTo))
				{
					ICalendarEventUser calendarEventUser = InterfaceActivator.Create<ICalendarEventUser>();
					calendarEventUser.User = informUser;
					calendarEventUser.Status = CalendarEventUserStatus.InfromTo;
					calendarEventUser.Event = base.Entity;
					base.Entity.EventUsers.Add(calendarEventUser);
				}
			}
		}
		if (_partyUsers == null || _partyUsers.Count <= 0)
		{
			return;
		}
		foreach (IUser partyUser in _partyUsers)
		{
			if (partyUser != null && !((IEnumerable<ICalendarEventUser>)base.Entity.EventUsers).Any((ICalendarEventUser u) => u.User == partyUser && u.Status == CalendarEventUserStatus.Participant))
			{
				ICalendarEventUser calendarEventUser2 = InterfaceActivator.Create<ICalendarEventUser>();
				calendarEventUser2.User = partyUser;
				calendarEventUser2.Status = CalendarEventUserStatus.Participant;
				calendarEventUser2.Event = base.Entity;
				base.Entity.EventUsers.Add(calendarEventUser2);
			}
		}
	}

	public FormViewItem FormViewItem(ViewType viewType)
	{
		FormViewItem form = Metadata<EntityMetadata>().DefaultForms.GetForm(viewType);
		return (FormViewItem)((viewType == ViewType.Display) ? form.CloneAsReadOnly() : form.Clone());
	}
}
