using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

[DataContract]
internal sealed class GlobalSettingsModuleInfo : IGlobalSettingsModuleInfo
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string DisplayName { get; set; }
}
