using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Services;

[Service(Scope = ServiceScope.Shell, InjectProperties = false, EnableInterceptors = false)]
internal sealed class AvailableTimeSlotsService : IAvailableTimeSlotsService
{
	private readonly ResourceCalendarManager resourceCalendarManager;

	private readonly IEnumerable<ICalendarItemProvider> calendarItemProviders;

	private readonly ScheduleManager scheduleManager;

	private readonly ITimeSlotsServiceValidator timeSlotsValidator;

	private readonly ISecurityService securityService;

	private readonly ITimeSlotsCalculationService timeSlotsCalculationService;

	private readonly AbsenceManager absenceManager;

	public AvailableTimeSlotsService(ResourceCalendarManager resourceCalendarManager, IEnumerable<ICalendarItemProvider> calendarItemProviders, ScheduleManager scheduleManager, ITimeSlotsServiceValidator timeSlotsValidator, ISecurityService securityService, ITimeSlotsCalculationService timeSlotsCalculationService, AbsenceManager absenceManager)
	{
		this.resourceCalendarManager = resourceCalendarManager;
		this.calendarItemProviders = calendarItemProviders;
		this.scheduleManager = scheduleManager;
		this.timeSlotsValidator = timeSlotsValidator;
		this.securityService = securityService;
		this.timeSlotsCalculationService = timeSlotsCalculationService;
		this.absenceManager = absenceManager;
	}

	public IList<TimeSlot> GetIntervals(IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<TimeSlot> timeSlots)
	{
		return GetIntervals(users.ToList(), null, timeSlots.ToList());
	}

	public IList<TimeSlot> GetIntervals(IEnumerable<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<ICalendarItem> calendarItems, IEnumerable<TimeSlot> timeSlots)
	{
		return GetIntervals(users.ToList(), calendarItems, timeSlots.ToList());
	}

	private IList<TimeSlot> GetIntervals(IList<EleWise.ELMA.Security.Models.IUser> users, IEnumerable<ICalendarItem> calendarItems, IList<TimeSlot> timeSlots)
	{
		timeSlotsValidator.Validate(users, timeSlots);
		foreach (TimeSlot timeSlot2 in timeSlots)
		{
			timeSlot2.StartDate = timeSlot2.StartDate.ToRuntimeDateTimeFromClient();
			timeSlot2.EndDate = timeSlot2.EndDate.ToRuntimeDateTimeFromClient();
		}
		IEnumerable<TimeSlot> normalizedIntervals = timeSlotsCalculationService.NormalizeIntervals(timeSlots);
		List<ISchedule> schedules = scheduleManager.GetUserSchedules(users).ToList();
		DateTime minStartDate = timeSlots.Min((TimeSlot m) => m.StartDate);
		DateTime maxEndDate = timeSlots.Max((TimeSlot m) => m.EndDate);
		List<ICalendarItem> events = new List<ICalendarItem>();
		securityService.RunWithElevatedPrivilegies(delegate
		{
			events.AddRange(calendarItemProviders.SelectMany((ICalendarItemProvider provider) => provider.GetItems(schedules, minStartDate, maxEndDate)));
		});
		normalizedIntervals = timeSlotsCalculationService.Subtraction(normalizedIntervals, events.Select((ICalendarItem @event) => new TimeSlot(@event.StartDate, @event.EndDate)));
		if (calendarItems != null && calendarItems.Any())
		{
			securityService.RunWithElevatedPrivilegies(delegate
			{
				normalizedIntervals = timeSlotsCalculationService.Subtraction(normalizedIntervals, calendarItems.Select((ICalendarItem @event) => new TimeSlot(@event.StartDate, @event.EndDate)));
			});
		}
		List<IAbsence> absences = new List<IAbsence>();
		securityService.RunWithElevatedPrivilegies(delegate
		{
			absences.AddRange(absenceManager.FindIntersection(users, minStartDate, maxEndDate));
		});
		normalizedIntervals = timeSlotsCalculationService.Subtraction(normalizedIntervals, absences.Select((IAbsence absence) => new TimeSlot(absence.StartDate, absence.EndDate)));
		IEnumerable<IResourceCalendar> calendars = resourceCalendarManager.GetByManyUserIds(users).Values.Distinct();
		ResourceCalendarWrapper calendar = UnionResourceCalendars(calendars);
		TimeSlot[] array = SubtractResourceCalendars(normalizedIntervals, calendar).ToArray();
		TimeSlot[] array2 = array;
		foreach (TimeSlot timeSlot in array2)
		{
			timeSlot.StartDate = timeSlot.StartDate.ToClientDateTime();
			timeSlot.EndDate = timeSlot.EndDate.ToClientDateTime();
		}
		return array;
	}

	private ResourceCalendarWrapper UnionResourceCalendars(IEnumerable<IResourceCalendar> calendars)
	{
		ResourceCalendarWrapper resourceCalendarWrapper = null;
		foreach (IResourceCalendar calendar in calendars)
		{
			ResourceCalendarWrapper resourceCalendarWrapper2 = new ResourceCalendarWrapper(timeSlotsCalculationService, calendar);
			if (resourceCalendarWrapper == null)
			{
				resourceCalendarWrapper = resourceCalendarWrapper2;
				continue;
			}
			for (int i = 1; i <= 7; i++)
			{
				List<TimeSlot> list = new List<TimeSlot>();
				if (resourceCalendarWrapper.WeekTimeSlots.TryGetValue(i, out var value) && resourceCalendarWrapper2.WeekTimeSlots.TryGetValue(i, out var value2))
				{
					foreach (TimeSlot item in value)
					{
						list.AddRange(timeSlotsCalculationService.Intersection(value2, item));
					}
				}
				resourceCalendarWrapper.WeekTimeSlots[i] = list;
			}
			resourceCalendarWrapper.ExceptionalSlots.AddRange(resourceCalendarWrapper2.ExceptionalSlots);
		}
		if (resourceCalendarWrapper != null)
		{
			resourceCalendarWrapper.ExceptionalSlots = timeSlotsCalculationService.NormalizeIntervals(resourceCalendarWrapper.ExceptionalSlots).ToList();
		}
		return resourceCalendarWrapper;
	}

	private IEnumerable<TimeSlot> SubtractResourceCalendars(IEnumerable<TimeSlot> timeSlots, ResourceCalendarWrapper calendar)
	{
		List<TimeSlot> list = new List<TimeSlot>();
		foreach (TimeSlot timeSlot in timeSlots)
		{
			list.AddRange(timeSlotsCalculationService.Intersection(calendar.GetOnTimeSlot(timeSlot), timeSlot));
		}
		return timeSlotsCalculationService.Subtraction(list, calendar.ExceptionalSlots);
	}
}
