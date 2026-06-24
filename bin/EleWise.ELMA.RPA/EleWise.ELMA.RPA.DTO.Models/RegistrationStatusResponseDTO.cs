using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class RegistrationStatusResponseDTO
{
	[DataMember(Name = "status")]
	public int Status { get; set; }

	[DataMember(Name = "ErrorMessage")]
	public string ErrorMessage { get; set; }
}
