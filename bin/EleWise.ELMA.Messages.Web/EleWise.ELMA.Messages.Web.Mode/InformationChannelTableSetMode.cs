using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;

namespace EleWise.ELMA.Messages.Web.Models;

public class InformationChannelTableSetModel
{
	public TypeChannelsEnum TypeChannels { get; set; }

	public List<IInformationChannel> Channels { get; set; }

	public List<IInformationChannel> LastChannelsHistory { get; set; }

	public InformationChannelTableSetModel()
	{
		TypeChannels = TypeChannelsEnum.General;
	}

	public List<IInformationChannel> ChannelsAll(bool withoutLast = false)
	{
		if (TypeChannels == TypeChannelsEnum.Last)
		{
			return LastChannelsHistory;
		}
		InfoChannelsEntityFilterProvider infoChannelsEntityFilterProvider = new InfoChannelsEntityFilterProvider();
		if (!(infoChannelsEntityFilterProvider.GetFilter(Guid.Empty, null) is IInformationChannelFilter informationChannelFilter))
		{
			return new List<IInformationChannel>();
		}
		informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		infoChannelsEntityFilterProvider.ApplyFilter(informationChannelFilter, TypeChannels.ToString());
		if (!withoutLast && LastChannelsHistory != null && LastChannelsHistory.Count > 0)
		{
			informationChannelFilter.WithoutIds = LastChannelsHistory.Select((IInformationChannel ch) => ch.Id).ToList();
		}
		return ChannelSelectorInfo.Instance.Channels(informationChannelFilter);
	}

	public List<IInformationChannel> GetLastChannels()
	{
		if (TypeChannels == TypeChannelsEnum.Last)
		{
			return LastChannelsHistory;
		}
		if (LastChannelsHistory == null || LastChannelsHistory.Count == 0)
		{
			return new List<IInformationChannel>();
		}
		InfoChannelsEntityFilterProvider infoChannelsEntityFilterProvider = new InfoChannelsEntityFilterProvider();
		if (!(infoChannelsEntityFilterProvider.GetFilter(Guid.Empty, null) is IInformationChannelFilter informationChannelFilter))
		{
			return new List<IInformationChannel>();
		}
		informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		infoChannelsEntityFilterProvider.ApplyFilter(informationChannelFilter, TypeChannels.ToString());
		informationChannelFilter.WithoutIds = LastChannelsHistory.Select((IInformationChannel ch) => ch.Id).ToList();
		return ChannelSelectorInfo.Instance.Channels(informationChannelFilter);
	}

	public long ChannelsCount(bool withoutLast = false)
	{
		if (TypeChannels == TypeChannelsEnum.Last)
		{
			return LastChannelsHistory.Count;
		}
		InfoChannelsEntityFilterProvider infoChannelsEntityFilterProvider = new InfoChannelsEntityFilterProvider();
		if (!(infoChannelsEntityFilterProvider.GetFilter(Guid.Empty, null) is IInformationChannelFilter informationChannelFilter))
		{
			return 0L;
		}
		informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		infoChannelsEntityFilterProvider.ApplyFilter(informationChannelFilter, TypeChannels.ToString());
		if (!withoutLast && LastChannelsHistory != null && LastChannelsHistory.Count > 0)
		{
			informationChannelFilter.WithoutIds = LastChannelsHistory.Select((IInformationChannel ch) => ch.Id).ToList();
		}
		return ChannelSelectorInfo.Instance.ChannelsCount(informationChannelFilter);
	}

	public List<IInformationChannel> GetChannels(List<long> withIds)
	{
		if (TypeChannels == TypeChannelsEnum.Last)
		{
			return LastChannelsHistory;
		}
		InfoChannelsEntityFilterProvider infoChannelsEntityFilterProvider = new InfoChannelsEntityFilterProvider();
		if (!(infoChannelsEntityFilterProvider.GetFilter(Guid.Empty, null) is IInformationChannelFilter informationChannelFilter))
		{
			return new List<IInformationChannel>();
		}
		informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		infoChannelsEntityFilterProvider.ApplyFilter(informationChannelFilter, TypeChannels.ToString());
		if (LastChannelsHistory != null && LastChannelsHistory.Count > 0)
		{
			informationChannelFilter.WithoutIds = LastChannelsHistory.Select((IInformationChannel ch) => ch.Id).ToList();
		}
		if (withIds != null && withIds.Count > 0)
		{
			informationChannelFilter.Ids = withIds;
		}
		return ChannelSelectorInfo.Instance.Channels(informationChannelFilter).ToList();
	}
}
