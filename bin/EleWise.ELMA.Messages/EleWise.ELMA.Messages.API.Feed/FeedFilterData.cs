using System;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Managers;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public sealed class FeedFilterData
{
	[DataMember]
	public DateTime DateFrom { get; set; }

	[DataMember]
	public DateTime DateTo { get; set; }

	[DataMember]
	public string SearchString { get; set; }

	[DataMember]
	public long[] CreationAuthors { get; set; }

	[DataMember]
	public bool Favorites { get; set; }

	internal static FeedFilter ToFeedFilter(FeedFilterData filterData)
	{
		if (filterData == null)
		{
			return null;
		}
		FeedFilter feedFilter = new FeedFilter();
		feedFilter.SearchString = filterData.SearchString;
		feedFilter.ChangeDate = new DateTimeRange((filterData.DateFrom.Equals(DateTime.MinValue) || filterData.DateFrom.Equals(DateTime.MaxValue)) ? null : new DateTime?(filterData.DateFrom), (filterData.DateTo.Equals(DateTime.MinValue) || filterData.DateTo.Equals(DateTime.MaxValue)) ? null : new DateTime?(filterData.DateTo));
		if (filterData.CreationAuthors != null && filterData.CreationAuthors.Length != 0)
		{
			feedFilter.CreationAuthor = UserManager.Instance.FindByIdArray(filterData.CreationAuthors).ToList();
		}
		feedFilter.Favorites = filterData.Favorites;
		return feedFilter;
	}
}
