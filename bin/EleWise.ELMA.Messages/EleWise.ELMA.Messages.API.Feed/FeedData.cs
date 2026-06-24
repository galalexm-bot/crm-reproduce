using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedData
{
	[DataMember]
	public int Count;

	[DataMember]
	public FeedPost[] Data;

	[DataMember]
	public string After;

	[DataMember]
	public string Before;

	[DataMember]
	public FeedPriority Priority;
}
