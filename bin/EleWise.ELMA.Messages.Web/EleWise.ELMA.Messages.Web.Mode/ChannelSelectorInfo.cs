using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelSelectorInfo
{
	private long count = -1L;

	private List<IInformationChannel> _channels;

	public string Id { get; set; }

	public static ChannelSelectorInfo Instance => new ChannelSelectorInfo();

	public List<IInformationChannel> Channels(IInformationChannelFilter filter = null)
	{
		if (_channels == null)
		{
			if (filter == null)
			{
				InstanceOf<IInformationChannelFilter> instanceOf = new InstanceOf<IInformationChannelFilter>();
				instanceOf.New.IsActive = true;
				instanceOf.New.IsArchive = false;
				filter = instanceOf.New;
			}
			_channels = InformationChannelManager.Instance.Find(filter, FetchOptions.All).ToList();
		}
		return _channels;
	}

	public long ChannelsCount(IInformationChannelFilter filter = null)
	{
		if (count == -1)
		{
			count = 0L;
			if (filter == null)
			{
				InstanceOf<IInformationChannelFilter> instanceOf = new InstanceOf<IInformationChannelFilter>();
				instanceOf.New.IsActive = true;
				instanceOf.New.IsArchive = false;
				filter = instanceOf.New;
			}
			count = InformationChannelManager.Instance.Count(filter);
		}
		return count;
	}
}
