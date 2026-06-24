using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Messages.Models;

[Serializable]
public class MessageSendHistory
{
	public Dictionary<long, DateTime> ChannelsList { get; set; }

	public void Add(List<long> ids)
	{
		DateTime now = DateTime.Now;
		foreach (long item in ids.Distinct((long a, long b) => a == b))
		{
			if (ChannelsList.ContainsKey(item))
			{
				ChannelsList[item] = now;
			}
			else
			{
				ChannelsList.Add(item, now);
			}
		}
	}

	public MessageSendHistory()
	{
		ChannelsList = new Dictionary<long, DateTime>();
	}
}
