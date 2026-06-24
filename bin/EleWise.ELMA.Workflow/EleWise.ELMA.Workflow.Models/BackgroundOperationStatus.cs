using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_BackgroundOperationStatus), "DisplayName")]
[Uid("1b800f40-10ae-45bc-baa2-33cfbfb29081")]
[MetadataType(typeof(EnumMetadata))]
[DefaultValueUid("f83f208a-bdb2-40ec-8b6e-1057059fa094")]
[ShowInDesigner(false)]
[ShowInTypeTree(false)]
public enum BackgroundOperationStatus
{
	[DisplayName(typeof(__Resources_BackgroundOperationStatus), "P_Prepared_DisplayName")]
	[Uid("f83f208a-bdb2-40ec-8b6e-1057059fa094")]
	Prepared,
	[Uid("44475a4e-3e20-431e-8693-4eb05a81be00")]
	[DisplayName(typeof(__Resources_BackgroundOperationStatus), "P_Active_DisplayName")]
	Active,
	[Uid("b6d0dfe6-66f9-4449-9667-04126f14e35c")]
	[DisplayName(typeof(__Resources_BackgroundOperationStatus), "P_Completed_DisplayName")]
	Completed,
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_BackgroundOperationStatus), "P_PendingCancellation_DisplayName")]
	[Uid("d87854a8-bc05-4c39-89ba-d3675653c571")]
	PendingCancellation,
	[DisplayName(typeof(__Resources_BackgroundOperationStatus), "P_PendingCallback_DisplayName")]
	[Uid("813fcf2f-c6c4-4d7c-8435-125d9aa3cf5a")]
	PendingCallback
}
