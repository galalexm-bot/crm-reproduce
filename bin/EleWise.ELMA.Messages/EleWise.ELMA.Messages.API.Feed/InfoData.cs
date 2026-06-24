using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class InfoData
{
	[DataMember]
	public int Count;

	[DataMember]
	public FeedInfoPost[] Data;

	[DataMember]
	public DateTime? After;
}
