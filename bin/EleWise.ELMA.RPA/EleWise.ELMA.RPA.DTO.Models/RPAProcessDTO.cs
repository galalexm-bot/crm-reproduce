using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class RPAProcessDTO
{
	[DataMember(Name = "uuid")]
	public Guid VersionUid { get; set; }

	[DataMember(Name = "token")]
	public Guid ProcessToken { get; set; }

	[DataMember(Name = "version")]
	public int Version { get; set; }

	[DataMember(Name = "active")]
	public bool Active { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "desc")]
	public string Description { get; set; }

	[DataMember(Name = "hash")]
	public string Hash { get; set; }

	[DataMember(Name = "created")]
	public DateTime CreationDate { get; set; }

	[DataMember(Name = "uploaded")]
	public DateTime UploadingDate { get; set; }

	[DataMember(Name = "useruuid")]
	public Guid UserUid { get; set; }

	[DataMember(Name = "fullname")]
	public string Fullname { get; set; }
}
