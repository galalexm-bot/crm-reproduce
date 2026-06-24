using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FavoriteData
{
	[DataMember]
	public int Count;

	[DataMember]
	public FeedFavoritePost[] Data;

	[DataMember]
	public string After;
}
