using System;
using System.Runtime.Serialization;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Calendar.API.Service;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract(Name = "CalendarItemPackage")]
public class CalendarItemPackage : PackageBase
{
	[DataMember]
	public CalendarItemWCF Data { get; set; }

	public CalendarItemPackage()
		: base(CalendarItemUpdatePackageService.serviceUid, CalendarItemUpdatePackageService.calendarItemTypeUid)
	{
	}

	public CalendarItemPackage(Guid typeuid)
		: base(CalendarItemUpdatePackageService.serviceUid, typeuid)
	{
	}
}
