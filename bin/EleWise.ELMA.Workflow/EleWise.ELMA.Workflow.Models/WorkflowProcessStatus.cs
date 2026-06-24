using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[Description(typeof(__Resources_WorkflowProcessStatus), "Description")]
[DisplayName(typeof(__Resources_WorkflowProcessStatus), "DisplayName")]
[Uid("bd364938-f8f2-4a6d-9a73-dfcd8f281556")]
public enum WorkflowProcessStatus
{
	[Uid("8c723a80-2e9c-4d50-bfca-54222aa28c23")]
	[DisplayName(typeof(__Resources_WorkflowProcessStatus), "P_Draft_DisplayName")]
	Draft,
	[DisplayName(typeof(__Resources_WorkflowProcessStatus), "P_Published_DisplayName")]
	[Uid("38ff406d-d438-4993-8439-40aa9253047a")]
	Published,
	[Uid("74d56c25-8fcc-475a-95a2-a91d3db6a21c")]
	[DisplayName(typeof(__Resources_WorkflowProcessStatus), "P_Obsolete_DisplayName")]
	Obsolete,
	[Uid("1440b819-b4fe-4d6f-9541-2473ad1d3b0b")]
	[DisplayName(typeof(__Resources_WorkflowProcessStatus), "P_Deleted_DisplayName")]
	Deleted,
	[Uid("95af537f-4dcc-4e3a-b9fb-cfc13ee4c782")]
	[DisplayName(typeof(__Resources_WorkflowProcessStatus), "P_debug_DisplayName")]
	debug
}
