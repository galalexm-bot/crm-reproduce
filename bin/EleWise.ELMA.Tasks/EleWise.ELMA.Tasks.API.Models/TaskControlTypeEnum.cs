using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskControlType")]
public enum TaskControlTypeEnum
{
	[EnumMember]
	Notification,
	[EnumMember]
	Execution,
	[EnumMember]
	Current
}
