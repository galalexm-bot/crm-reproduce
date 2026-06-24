using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UIBuilder.Web.Models;

[DataContract]
internal sealed class FormViewItemHeader
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string DisplayName { get; set; }

	[DataMember]
	public int RuntimeVersion { get; set; }

	[DataMember]
	public Guid GroupUid { get; set; }

	[DataMember]
	public Guid TargetUid { get; set; }
}
