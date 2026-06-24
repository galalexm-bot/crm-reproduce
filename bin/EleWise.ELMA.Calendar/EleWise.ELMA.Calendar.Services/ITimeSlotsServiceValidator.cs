using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Services;

internal interface ITimeSlotsServiceValidator
{
	void Validate(IList<IUser> users, IList<TimeSlot> timeSlots);
}
