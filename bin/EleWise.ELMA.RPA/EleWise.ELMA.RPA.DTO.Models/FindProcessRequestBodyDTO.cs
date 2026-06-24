using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class FindProcessRequestBodyDTO
{
	[DataMember(Name = "auth_tkn")]
	public Guid AuthToken { get; set; }

	[DataMember(Name = "token")]
	public Guid ProcessToken { get; set; }

	[DataMember(Name = "version")]
	public int Version { get; set; }
}
