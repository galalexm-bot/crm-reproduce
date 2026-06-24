using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class AssemblyReference
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public Guid Uid { get; set; }
}
