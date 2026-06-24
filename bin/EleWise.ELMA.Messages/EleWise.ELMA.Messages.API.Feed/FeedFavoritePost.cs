using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedFavoritePost
{
	[DataMember]
	public long ObjectId { get; set; }

	[DataMember]
	public Guid ObjectUid { get; set; }

	[DataMember]
	public string ObjectHash { get; set; }

	[DataMember]
	public bool IsDelete { get; set; }

	public static FeedFavoritePost Create(FeedFavoriteModel model)
	{
		return new FeedFavoritePost
		{
			ObjectId = model.ActionObjectId,
			ObjectUid = model.ActionObjectUid,
			ObjectHash = (model.IsDelete ? "" : model.ChangeDateHash),
			IsDelete = model.IsDelete
		};
	}
}
