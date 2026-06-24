using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class ContextVariableDTO
{
	[DataMember(Name = "desc")]
	public string Description { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "scope")]
	public string Scope { get; set; }

	[DataMember(Name = "type")]
	public string Type { get; set; }

	[DataMember(Name = "caption")]
	public string Caption { get; set; }
}
