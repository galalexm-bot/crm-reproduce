using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class TaskCreateRequestBodyDTO
{
	[DataMember(Name = "auth_tkn")]
	public Guid AuthToken { get; set; }

	[DataMember(Name = "task")]
	public TaskDTO Task { get; set; }
}
