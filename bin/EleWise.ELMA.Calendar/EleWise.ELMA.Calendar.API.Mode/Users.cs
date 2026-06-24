using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract]
public sealed class Users
{
	[DataMember]
	public long[] Ids { get; set; }
}
