using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class FindProcessResponseDTO
{
	[DataMember(Name = "status")]
	public int Status { get; set; }

	[DataMember(Name = "process")]
	public RPAProcessDTO Process { get; set; }
}
