using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

[DataContract]
public sealed class InitDataModel
{
	[DataMember]
	public Guid[] Modules { get; set; }

	public InitDataModel()
	{
		Modules = new Guid[0];
	}
}
