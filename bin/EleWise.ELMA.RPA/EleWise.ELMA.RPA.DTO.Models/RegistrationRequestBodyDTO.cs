using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class RegistrationRequestBodyDTO
{
	[DataMember(Name = "uuid")]
	public Guid Token { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "desc")]
	public string Description { get; set; }
}
