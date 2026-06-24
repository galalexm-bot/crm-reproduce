using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.Models;

[Serializable]
[DataContract]
public class MessageSettingsInfo
{
	[DataMember]
	public List<ChannelSettingsInfo> Channels { get; set; }

	[DataMember]
	public List<ObjectSettingsInfo> Objects { get; set; }

	public MessageSettingsInfo()
	{
		Channels = new List<ChannelSettingsInfo>();
		Objects = new List<ObjectSettingsInfo>();
		ComponentManager.Current.GetExtensionPoints<IMessageChannel>().ToList().ForEach(delegate(IMessageChannel a)
		{
			Channels.Add(new ChannelSettingsInfo
			{
				Uid = a.Uid,
				DisplayName = a.DisplayName
			});
		});
	}
}
