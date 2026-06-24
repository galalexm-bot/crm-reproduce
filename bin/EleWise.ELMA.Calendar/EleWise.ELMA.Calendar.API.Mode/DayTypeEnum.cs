using System.Runtime.Serialization;

namespace EleWise.ELMA.Calendar.API.Models;

[DataContract(Name = "DayType")]
public enum DayTypeEnum
{
	[EnumMember]
	Short,
	[EnumMember]
	Holiday,
	[EnumMember]
	Work
}
