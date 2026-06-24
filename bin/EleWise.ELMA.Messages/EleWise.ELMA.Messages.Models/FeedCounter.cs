using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
[DataContract]
public class FeedCounter
{
	[DataMember]
	public long Count { get; set; }

	[DataMember]
	public bool WithPriority { get; set; }
}
