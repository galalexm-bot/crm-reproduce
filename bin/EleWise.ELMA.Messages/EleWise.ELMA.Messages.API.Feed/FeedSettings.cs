using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedSettings
{
	[DataMember]
	public bool PostCommentEnterKey;

	[DataMember]
	public int MessagesCount;

	[DataMember]
	public int CommentsCount;
}
