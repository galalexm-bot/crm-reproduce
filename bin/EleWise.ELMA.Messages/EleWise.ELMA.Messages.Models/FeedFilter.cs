using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

public class FeedFilter
{
	private string searchString = "";

	public DateTimeRange ChangeDate { get; set; }

	public bool OnlyUnread { get; set; }

	public bool Favorites { get; set; }

	public List<IUser> CreationAuthor { get; set; }

	public string SearchString
	{
		get
		{
			return searchString;
		}
		set
		{
			searchString = (value ?? "").Trim();
			if (searchString.Length < 3)
			{
				searchString = "";
			}
			searchString = searchString.Substring(0, Math.Min(searchString.Length, 255));
		}
	}

	public FeedFilter()
	{
		DateTime realArchiveDateLimit = FeedManager.Instance.GetRealArchiveDateLimit();
		ChangeDate = new DateTimeRange((realArchiveDateLimit == DateTime.MinValue) ? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Date.AddMonths(-6) : realArchiveDateLimit, null);
	}

	public bool IsEmpty()
	{
		if (string.IsNullOrEmpty(searchString) && !ChangeDate.From.HasValue && !ChangeDate.To.HasValue)
		{
			if (CreationAuthor != null)
			{
				return !CreationAuthor.Any();
			}
			return true;
		}
		return false;
	}
}
