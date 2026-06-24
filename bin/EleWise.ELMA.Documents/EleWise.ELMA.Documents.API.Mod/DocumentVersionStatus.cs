using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.API.Models;

[DataContract]
public enum DocumentVersionStatus
{
	[EnumMember(Value = "0")]
	Draft,
	[EnumMember(Value = "1")]
	Obsolete,
	[EnumMember(Value = "2")]
	Current,
	[EnumMember(Value = "3")]
	Deleted,
	[EnumMember(Value = "4")]
	Signed,
	[EnumMember(Value = "5")]
	InArchive
}
