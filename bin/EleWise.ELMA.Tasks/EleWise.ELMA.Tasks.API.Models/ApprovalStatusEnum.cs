using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ApprovalStatus")]
public enum ApprovalStatusEnum
{
	[EnumMember]
	None,
	[EnumMember]
	Confirm,
	[EnumMember]
	Unconfirm,
	[EnumMember]
	Terminated,
	[EnumMember]
	WasClosed
}
