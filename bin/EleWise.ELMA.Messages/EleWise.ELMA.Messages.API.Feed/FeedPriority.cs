using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public enum FeedPriority
{
	[EnumMember(Value = "-100")]
	Lowest = -100,
	[EnumMember(Value = "-10")]
	Low = -10,
	[EnumMember(Value = "0")]
	Normal = 0,
	[EnumMember(Value = "10")]
	High = 10,
	[EnumMember(Value = "100")]
	Urgent = 100
}
