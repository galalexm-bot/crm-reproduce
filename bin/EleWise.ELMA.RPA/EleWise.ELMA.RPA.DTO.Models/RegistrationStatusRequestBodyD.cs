using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class RegistrationStatusRequestBodyDTO
{
	[DataMember(Name = "uuid")]
	public Guid Token { get; set; }
}
