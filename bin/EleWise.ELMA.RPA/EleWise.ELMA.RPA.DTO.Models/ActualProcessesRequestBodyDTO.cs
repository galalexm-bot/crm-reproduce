using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class ActualProcessesRequestBodyDTO
{
	[DataMember(Name = "auth_tkn")]
	public Guid AuthToken { get; set; }

	[DataMember(Name = "page")]
	public int Page { get; set; }

	[DataMember(Name = "limit")]
	public int Limit { get; set; }
}
