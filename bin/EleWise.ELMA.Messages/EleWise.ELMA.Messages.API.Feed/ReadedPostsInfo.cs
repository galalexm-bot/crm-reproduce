using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class ReadedPostsInfo
{
	[DataMember]
	public long[] PostsIds;

	[DataMember]
	public DateTime Now;

	[DataMember]
	public string DateHashLast;
}
