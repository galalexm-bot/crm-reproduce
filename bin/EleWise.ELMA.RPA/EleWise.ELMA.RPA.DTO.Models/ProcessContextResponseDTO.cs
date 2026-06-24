using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class ProcessContextResponseDTO
{
	[DataMember(Name = "status")]
	public int Status { get; set; }

	[DataMember(Name = "ctx")]
	public List<ContextVariableDTO> ContextVariables { get; set; }
}
