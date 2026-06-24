using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class ActualProcessesResponseDTO
{
	[DataMember(Name = "status")]
	public int Status { get; set; }

	[DataMember(Name = "total")]
	public int Total { get; set; }

	[DataMember(Name = "process")]
	public List<RPAProcessDTO> Processes { get; set; } = new List<RPAProcessDTO>();

}
