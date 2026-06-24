using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.API.Models;

[Serializable]
[DataContract]
public sealed class TimeSlotsData
{
	[DataMember]
	public Users Users { get; set; }

	[DataMember]
	public TimeSlot[] TimeSlots { get; set; }
}
