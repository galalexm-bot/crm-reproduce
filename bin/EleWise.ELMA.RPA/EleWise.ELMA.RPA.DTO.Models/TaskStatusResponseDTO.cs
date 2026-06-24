using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class TaskStatusResponseDTO
{
	[DataMember(Name = "status")]
	public int Status { get; set; }

	[DataMember(Name = "task")]
	public TaskDTO Task { get; set; }
}
