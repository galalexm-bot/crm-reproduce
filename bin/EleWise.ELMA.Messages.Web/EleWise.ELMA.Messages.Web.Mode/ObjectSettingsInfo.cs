using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.Web.Models;

[Serializable]
[DataContract]
public class ObjectSettingsInfo
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string DisplayName { get; set; }

	[DataMember]
	public List<ActionSettingsInfo> ActionsInfo { get; set; }

	public ObjectSettingsInfo()
	{
		ActionsInfo = new List<ActionSettingsInfo>();
	}
}
