using System.Runtime.Serialization;

namespace EleWise.ELMA.Documents.Services;

[DataContract]
public enum StatusScanedFileEnum
{
	[EnumMember(Value = "0")]
	SCAN_START,
	[EnumMember(Value = "1")]
	SCAN_INPROGRESS,
	[EnumMember(Value = "2")]
	SCAN_FINISHED,
	[EnumMember(Value = "3")]
	SCAN_FINISHED_ERROR,
	[EnumMember(Value = "4")]
	SCAN_CANCEL
}
