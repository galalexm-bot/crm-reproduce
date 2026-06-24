using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class LastCommentsData
{
	[DataMember]
	public int Count;

	[DataMember]
	public FeedComment[] Data;

	[DataMember]
	public string After;

	[DataMember]
	public string Before;

	public static LastCommentsData CreateLastCommentsData(FeedModel model)
	{
		LastCommentsData lastCommentsData = new LastCommentsData();
		List<FeedComment> list = ((model.Messages != null) ? model.Messages.Select(FeedComment.CreateFeedComment).ToList() : new List<FeedComment>());
		lastCommentsData.Data = list.ToArray();
		if (list.Any())
		{
			lastCommentsData.After = MessageFeedService.ShuffleHash(list.First().RealHash);
			lastCommentsData.Before = MessageFeedService.ShuffleHash(list.Last().RealHash);
		}
		lastCommentsData.Count = lastCommentsData.Data.Count();
		return lastCommentsData;
	}
}
