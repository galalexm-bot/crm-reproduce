using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Common.Mobile.API.Internal.Models;

[Serializable]
[DataContract(Name = "GetHistory")]
internal class GetEntityHistoryRequest : IGetEntityHistoryRequest
{
	[DataMember]
	public bool? OrderDesc { get; set; }

	[DataMember]
	public int? FirstResult { get; set; }

	[DataMember]
	public int? MaxResults { get; set; }

	[DataMember]
	public long? LastActionDate { get; set; }

	[DataMember]
	public int? PackageIndex { get; set; }
}
