using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class AvailableTimeResult
{
	[DisplayName("SR.M('Дата начала')")]
	public DateTime StartDate { get; set; }

	[DisplayName("SR.M('Дата окончания')")]
	public DateTime EndDate { get; set; }

	[DisplayName("SR.M('Продолжительность')")]
	public EventDuration Duration { get; set; }

	[DisplayName("SR.M('Доступное время')")]
	public IEnumerable<IGrouping<DateTime, TimeSlot>> AvailableTimeSlotsByDays { get; set; }

	public string UserIds { get; set; }

	public bool PartOfCrossingEvents { get; set; }

	public string Prefix { get; set; }

	public DateTime StartDateToPaging { get; set; }

	public long[] ScheduleIds { get; set; }

	public AvailableTimeResult()
	{
	}

	public AvailableTimeResult(AvailableTimeSearch model)
	{
		StartDate = ((model.StartDate > DateTime.MinValue) ? model.StartDate : DateTime.Today);
		Duration = EventDuration.HalfHour;
		PartOfCrossingEvents = model.InCrossingEvents;
		Prefix = Guid.NewGuid().ToStringId();
		UserIds = ClassSerializationHelper.SerializeObjectByJson(model.UserIds);
		ScheduleIds = model.ScheduleIds;
	}
}
