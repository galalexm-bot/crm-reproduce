using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.Web.Models;

[Serializable]
[DataContract]
public class ChannelSettingsInfo
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string DisplayName { get; set; }

	[DataMember]
	public bool Checked { get; set; }
}
