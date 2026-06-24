using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Services;

[Service]
internal class TimeSlotsServiceValidator : ITimeSlotsServiceValidator
{
	public void Validate(IList<IUser> users, IList<TimeSlot> timeSlots)
	{
		Contract.ArgumentNotNull(users, "users");
		Contract.CheckArgument(users.Count > 0, "users.Any()");
		Contract.ArgumentNotNull(timeSlots, "timeSlots");
		Contract.CheckArgument(timeSlots.Count > 0, "timeSlots.Any()");
		for (int i = 0; i < timeSlots.Count; i++)
		{
			Contract.CheckArgument(timeSlots[i].StartDate > DateTime.MinValue, $"timeSlots[{i}].StartDate > DateTime.MinValue");
			Contract.CheckArgument(timeSlots[i].EndDate < DateTime.MaxValue, $"timeSlots[{i}].EndDate < DateTime.MaxValue");
			Contract.CheckArgument(timeSlots[i].StartDate < timeSlots[i].EndDate, string.Format("timeSlots[{0}].StartDate < timeSlots[{0}].EndDate", i));
		}
		TimeSlot timeSlot = new TimeSlot(timeSlots.Min((TimeSlot m) => m.StartDate), timeSlots.Max((TimeSlot m) => m.EndDate));
		Contract.CheckArgument(timeSlot.StartDate.AddYears(1) >= timeSlot.EndDate, SR.T("Запрошенное суммарное время превышает 1 год"));
	}
}
