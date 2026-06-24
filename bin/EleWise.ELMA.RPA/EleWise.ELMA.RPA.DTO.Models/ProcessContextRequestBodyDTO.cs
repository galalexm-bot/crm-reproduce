using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class ProcessContextRequestBodyDTO
{
	[DataMember(Name = "auth_tkn")]
	public Guid AuthToken { get; set; }

	[DataMember(Name = "uuid")]
	public Guid ProcessVersionUid { get; set; }
}
