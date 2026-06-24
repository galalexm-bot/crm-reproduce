using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

[DataContract]
internal sealed class ModuleSettingsParameters
{
	[DataMember]
	public Guid Module { get; set; }

	[DataMember]
	public string[] Settings { get; set; }
}
