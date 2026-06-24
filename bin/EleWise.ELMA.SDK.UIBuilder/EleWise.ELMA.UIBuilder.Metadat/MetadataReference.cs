using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

[DataContract]
public sealed class MetadataReference
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string TypeRef { get; set; }
}
