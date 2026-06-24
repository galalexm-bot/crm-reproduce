using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.Web.Models;

[DataContract]
internal sealed class SearchComponentHeaderRequest
{
	[DataMember]
	public Guid DataClassUid { get; set; }

	[DataMember]
	public int ViewType { get; set; }

	[DataMember]
	public UIRuntimeModel RuntimeModel { get; set; }
}
