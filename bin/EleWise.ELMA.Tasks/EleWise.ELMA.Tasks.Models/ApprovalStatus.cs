using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("9cde21b5-7990-4599-a080-87645e05913a")]
[DisplayName(typeof(__Resources_ApprovalStatus), "DisplayName")]
[Description(typeof(__Resources_ApprovalStatus), "Description")]
public enum ApprovalStatus
{
	[Uid("fa4191cd-80cd-4141-aaad-5c75164e1beb")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_None_DisplayName")]
	[Image(typeof(ApprovalStatus), "help", 16, ImageFormatType.IconPack, false)]
	None,
	[Uid("f4f62e3b-5f2a-40bd-a192-26591c1f3a5a")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_Confirm_DisplayName")]
	[View(Visibility.Hidden)]
	[Image(typeof(ApprovalStatus), "complete", 16, ImageFormatType.IconPack, false)]
	Confirm,
	[Uid("9ace61bf-b4c8-4498-80c7-9a833000ff9a")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_Unconfirm_DisplayName")]
	[Image(typeof(ApprovalStatus), "close_outline", 16, ImageFormatType.IconPack, false)]
	Unconfirm,
	[Uid("b4bc8a4b-47ee-4a0a-85f5-6c9049e7644e")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_Terminated_DisplayName")]
	[View(Visibility.Hidden)]
	[Image(typeof(ApprovalStatus), "error", 16, ImageFormatType.IconPack, false)]
	Terminated,
	[Uid("de574188-7175-4251-9576-1ef9485021da")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_WasClosed_DisplayName")]
	[Image(typeof(ApprovalStatus), "close_outline", 16, ImageFormatType.IconPack, false)]
	WasClosed,
	[Uid("ee241335-7181-4f42-ae34-983ea8a9ef98")]
	[DisplayName(typeof(__Resources_ApprovalStatus), "P_Pending_DisplayName")]
	Pending
}
