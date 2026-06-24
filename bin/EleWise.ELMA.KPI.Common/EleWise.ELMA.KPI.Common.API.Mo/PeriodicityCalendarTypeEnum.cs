using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.KPI.Common.API.Models;

[Serializable]
[DataContract(Name = "PeriodicityCalendarType")]
public enum PeriodicityCalendarTypeEnum
{
	[EnumMember]
	AllDays,
	[EnumMember]
	ProductionSchedule
}
