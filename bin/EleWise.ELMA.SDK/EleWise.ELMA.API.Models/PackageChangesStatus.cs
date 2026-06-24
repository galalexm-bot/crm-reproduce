using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.API.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("b312e8c7-5241-4c59-8219-ab701956c065")]
[DisplayName(typeof(__Resources_PackageChangesStatus), "DisplayName")]
public enum PackageChangesStatus
{
	[DisplayName(typeof(__Resources_PackageChangesStatus), "P_New_DisplayName")]
	[Uid("30346b54-7362-4f92-90dc-4714a8744051")]
	New,
	[DisplayName(typeof(__Resources_PackageChangesStatus), "P_Completed_DisplayName")]
	[Uid("fe913b0d-d588-4798-a201-2ab664bc5450")]
	Completed
}
