using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;
using EleWise.ELMA.Messages.Web.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Web.Models;

public class InformationChannelSetModel
{
	private List<IInformationChannel> _lastChannelsHistory;

	private int? maxCount;

	public long GeneralChannelsCount { get; set; }

	public long OverChannelsCount { get; set; }

	public InformationChannelSelectModel GeneralChannels { get; set; }

	public InformationChannelSelectModel OverChannels { get; set; }

	public InformationChannelSelectModel LastChannels { get; set; }

	private List<IInformationChannel> LastChannelsHistory
	{
		get
		{
			if (_lastChannelsHistory == null)
			{
				IMessageSendHistoryService service = Locator.GetService<IMessageSendHistoryService>();
				_lastChannelsHistory = new List<IInformationChannel>(service.Get().ToList());
			}
			return _lastChannelsHistory.ToList();
		}
	}

	public InformationChannelSetModel()
	{
		Init();
	}

	public InformationChannelSetModel(ISet<IInformationChannel> channels)
	{
		Init(channels);
	}

	private void Init(ISet<IInformationChannel> channels = null)
	{
		GeneralChannels = new InformationChannelSelectModel
		{
			TypeChannels = TypeChannelsEnum.General
		};
		OverChannels = new InformationChannelSelectModel
		{
			TypeChannels = TypeChannelsEnum.Over
		};
		LastChannels = new InformationChannelSelectModel
		{
			TypeChannels = TypeChannelsEnum.Last
		};
		SetChannels(channels);
	}

	public void SetChannels(ISet<IInformationChannel> channels)
	{
		GeneralChannelsCount = GeneralChannels.Channels.ChannelsCount(withoutLast: true);
		OverChannelsCount = OverChannels.Channels.ChannelsCount(withoutLast: true);
		List<IInformationChannel> lastChannelsHistory = LastChannelsHistory.ToList();
		if (GeneralChannelsCount > MaxCountChannels() || OverChannelsCount > MaxCountChannels())
		{
			if (GeneralChannelsCount <= MaxCountChannels())
			{
				lastChannelsHistory = GeneralChannels.Channels.GetChannels(LastChannelsHistory.Select((IInformationChannel ch) => ch.Id).ToList());
			}
			lastChannelsHistory = lastChannelsHistory.Take(MaxCountChannels()).ToList();
		}
		else
		{
			lastChannelsHistory.Clear();
		}
		GeneralChannels.Channels.LastChannelsHistory = lastChannelsHistory;
		OverChannels.Channels.LastChannelsHistory = lastChannelsHistory;
		LastChannels.Channels.LastChannelsHistory = lastChannelsHistory;
		if (channels == null)
		{
			return;
		}
		LastChannels.Channels.Channels = lastChannelsHistory.Where((IInformationChannel lch) => ((IEnumerable<IInformationChannel>)channels).Any((IInformationChannel ch) => ch.Id == lch.Id)).ToList();
		GeneralChannels.Channels.Channels = ((IEnumerable<IInformationChannel>)channels).Where((IInformationChannel c) => c.GroupUid == Guid.Empty && lastChannelsHistory.All((IInformationChannel lch) => lch.Id != c.Id)).ToList();
		OverChannels.Channels.Channels = ((IEnumerable<IInformationChannel>)channels).Where((IInformationChannel c) => c.GroupUid != Guid.Empty && lastChannelsHistory.All((IInformationChannel lch) => lch.Id != c.Id)).ToList();
	}

	public ISet<IInformationChannel> GetChannels()
	{
		List<IInformationChannel> channels = new List<IInformationChannel>();
		if (GeneralChannels.Channels != null && GeneralChannels.Channels.Channels != null)
		{
			channels.AddRange(GeneralChannels.Channels.Channels);
		}
		if (OverChannels.Channels != null && OverChannels.Channels.Channels != null)
		{
			channels.AddRange(OverChannels.Channels.Channels.Where((IInformationChannel ch) => !channels.Exists((IInformationChannel c) => c.Id == ch.Id)));
		}
		if (LastChannels.Channels != null && LastChannels.Channels.Channels != null)
		{
			channels.AddRange(LastChannels.Channels.Channels.Where((IInformationChannel ch) => !channels.Exists((IInformationChannel c) => c.Id == ch.Id)));
		}
		return (ISet<IInformationChannel>)(object)new HashedSet<IInformationChannel>((ICollection<IInformationChannel>)channels);
	}

	public int MaxCountChannels()
	{
		if (!maxCount.HasValue)
		{
			maxCount = Settings.GetSettings().MaxShowInfoChannelsForSelect;
		}
		return maxCount.Value;
	}
}
