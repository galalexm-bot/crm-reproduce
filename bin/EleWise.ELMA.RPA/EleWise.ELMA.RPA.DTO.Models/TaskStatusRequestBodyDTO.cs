using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class TaskStatusRequestBodyDTO
{
	[DataMember(Name = "auth_tkn")]
	public Guid AuthToken { get; set; }

	[DataMember(Name = "id")]
	public int Id { get; set; }
}
