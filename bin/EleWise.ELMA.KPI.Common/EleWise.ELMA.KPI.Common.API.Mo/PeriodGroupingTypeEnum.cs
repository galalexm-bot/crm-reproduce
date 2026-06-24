using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.KPI.Common.API.Models;

[Serializable]
[DataContract(Name = "PeriodGroupingType")]
public enum PeriodGroupingTypeEnum
{
	[EnumMember]
	FirstDay,
	[EnumMember]
	MiddleDay,
	[EnumMember]
	LastDay
}
