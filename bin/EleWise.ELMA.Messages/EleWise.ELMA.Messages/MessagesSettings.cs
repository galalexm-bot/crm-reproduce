using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Messages;

public class MessagesSettings : GlobalSettingsBase
{
	private const int DefaultMaxShowInfoChannelsForSelect = 10;

	private int maxShowInfoChannelsForSelect;

	[DisplayName(typeof(__Resources_MessagesSettings), "MaxShowInfoChannelsForSelect")]
	public int MaxShowInfoChannelsForSelect
	{
		get
		{
			return maxShowInfoChannelsForSelect;
		}
		set
		{
			maxShowInfoChannelsForSelect = ((value >= 0) ? value : 10);
		}
	}

	[DisplayName(typeof(__Resources_MessagesSettings), "FeedLimitToArchivePeriod")]
	public FeedLimitToArchive FeedLimitToArchivePeriod { get; set; }

	public MessagesSettings()
	{
		MaxShowInfoChannelsForSelect = 10;
		FeedLimitToArchivePeriod = FeedLimitToArchive.Three;
	}
}
