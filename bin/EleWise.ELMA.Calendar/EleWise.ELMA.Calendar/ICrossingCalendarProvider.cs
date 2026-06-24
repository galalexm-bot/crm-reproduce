using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ICrossingCalendarProvider
{
	IEnumerable<Guid> TypeUids { get; }

	void FillData(Guid typeUid, long id, ICollection<IUser> owners, ICollection<ISchedule> schedules);
}
