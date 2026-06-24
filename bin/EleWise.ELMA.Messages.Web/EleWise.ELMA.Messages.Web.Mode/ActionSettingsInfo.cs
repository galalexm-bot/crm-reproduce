using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.Models;

[Serializable]
[DataContract]
public class ActionSettingsInfo
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string DisplayName { get; set; }

	[DataMember]
	public bool Checked { get; set; }

	[DataMember]
	public List<ChannelSettingsInfo> ChannelsInfo { get; set; }

	public ActionSettingsInfo()
	{
		ChannelsInfo = new List<ChannelSettingsInfo>();
	}

	public void Init()
	{
		ComponentManager.Current.GetExtensionPoints<IMessageChannel>().ToList().ForEach(delegate(IMessageChannel a)
		{
			ChannelsInfo.Add(new ChannelSettingsInfo
			{
				Uid = a.Uid,
				DisplayName = a.DisplayName,
				Checked = false
			});
		});
	}
}
