using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

[DataContract]
public sealed class SystemInitData
{
	[DataMember]
	public IEnumerable<MetadataReference> MetadataReferences { get; set; }

	[DataMember]
	public ItemRuntimeModel[] ItemRuntimeModels { get; set; }
}
