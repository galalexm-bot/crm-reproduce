using System;
using System.Globalization;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class SearchFieldsModel
{
	public FeedFilter Filter { get; set; }

	public long UnreadCount { get; set; }

	public long UnreadCountRed { get; set; }

	public long UnreadCountBlue
	{
		get
		{
			long num = UnreadCount - UnreadCountRed;
			if (num >= 0)
			{
				return num;
			}
			return 0L;
		}
	}

	public string UnreadCountRedToString
	{
		get
		{
			if (UnreadCountRed <= 0)
			{
				return "";
			}
			if (UnreadCountRed > 99)
			{
				return "99+";
			}
			return UnreadCountRed.ToString(CultureInfo.InvariantCulture);
		}
	}

	public string UnreadCountBlueToString
	{
		get
		{
			if (UnreadCountBlue <= 0)
			{
				return "";
			}
			if (UnreadCountBlue > 99)
			{
				return "99+";
			}
			return UnreadCountBlue.ToString(CultureInfo.InvariantCulture);
		}
	}

	public bool OnlyUnread { get; set; }

	public bool IsSearch { get; set; }

	public bool Favorites { get; set; }

	public string HeaderContent { get; set; }

	public SearchFieldsModel()
	{
		Filter = new FeedFilter();
	}

	public DateTime RealArchiveDateLimit()
	{
		return FeedManager.Instance.GetRealArchiveDateLimit();
	}
}
