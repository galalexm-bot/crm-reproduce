using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedInfoPost
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public long Recipient { get; set; }

	[DataMember]
	public Guid ActionObjectUid { get; set; }

	[DataMember]
	public long ActionObjectId { get; set; }

	[DataMember]
	public DateTime ChangeDate { get; set; }

	[DataMember]
	public string Data { get; set; }

	public static FeedInfoPost Create(FeedMessageInfoModel model)
	{
		return new FeedInfoPost
		{
			Id = model.Id,
			Recipient = model.Recipient,
			ActionObjectId = model.ActionObjectId,
			ActionObjectUid = model.ActionObjectUid,
			ChangeDate = model.ChangeDate,
			Data = ClassSerializationHelper.SerializeObjectByJson(model.Data)
		};
	}
}
