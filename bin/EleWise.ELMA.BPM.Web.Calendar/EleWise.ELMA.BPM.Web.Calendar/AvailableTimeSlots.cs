using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class AvailableTimeSlots
{
	public IEnumerable<IGrouping<DateTime, TimeSlot>> AvailableTimeSlotsByDays { get; set; }

	public string Prefix { get; set; }
}
