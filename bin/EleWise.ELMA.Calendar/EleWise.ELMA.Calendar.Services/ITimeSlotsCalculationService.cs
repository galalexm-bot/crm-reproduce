using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Services;

internal interface ITimeSlotsCalculationService
{
	IList<TimeSlot> NormalizeIntervals(IList<TimeSlot> timeSlots);

	IEnumerable<TimeSlot> Subtraction(IEnumerable<TimeSlot> timeSlots, IEnumerable<TimeSlot> timesSearched);

	IList<TimeSlot> Intersection(IList<TimeSlot> timeSlots, TimeSlot timeSearched);
}
