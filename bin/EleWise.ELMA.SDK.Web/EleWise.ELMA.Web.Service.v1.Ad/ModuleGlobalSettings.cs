using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

[DataContract]
internal sealed class ModuleGlobalSettings : IModuleGlobalSettings
{
	[DataMember]
	public ISettings[] Settings { get; set; }
}
