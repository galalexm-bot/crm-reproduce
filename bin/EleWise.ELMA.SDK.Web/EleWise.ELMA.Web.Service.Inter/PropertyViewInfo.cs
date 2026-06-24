using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class PropertyViewInfo
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public bool? ReadOnly { get; set; }

	[DataMember]
	public bool? Visible { get; set; }

	[DataMember]
	public bool? Required { get; set; }

	[DataMember]
	public bool? IsValid { get; set; }

	[DataMember]
	public string ValidationMessage { get; set; }

	[DataMember]
	public object Settings { get; set; }
}
