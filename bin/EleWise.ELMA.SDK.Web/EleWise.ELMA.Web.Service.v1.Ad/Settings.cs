using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

[DataContract]
internal sealed class Settings : ISettings
{
	[DataMember]
	public string Name { get; }

	[DataMember]
	public string Value { get; }

	public Settings(string name, string value)
	{
		Name = name;
		Value = value;
	}
}
