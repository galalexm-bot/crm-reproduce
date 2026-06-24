using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.KPI.Common.API.Models;

[Serializable]
[DataContract(Name = "PeriodicityType")]
public enum PeriodicityTypeEnum
{
	[EnumMember]
	None,
	[EnumMember]
	Day,
	[EnumMember]
	Week,
	[EnumMember]
	Month,
	[EnumMember]
	Quarter,
	[EnumMember]
	HalfYear,
	[EnumMember]
	Year,
	[EnumMember]
	Custom
}
