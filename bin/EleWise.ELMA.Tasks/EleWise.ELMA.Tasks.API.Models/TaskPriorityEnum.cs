using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskPriority")]
public enum TaskPriorityEnum
{
	[EnumMember]
	High = 1,
	[EnumMember]
	Medium,
	[EnumMember]
	Low
}
