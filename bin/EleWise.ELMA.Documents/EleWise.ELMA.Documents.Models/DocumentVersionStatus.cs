using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("59132aab-9f3a-4ca3-bca4-3624ad768699")]
[DisplayName(typeof(__Resources_DocumentVersionStatus), "DisplayName")]
public enum DocumentVersionStatus
{
	[Uid("09078dde-3ea5-481a-bb97-c970bb052c49")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_Draft_DisplayName")]
	Draft,
	[Uid("2749be9e-64ad-49df-be32-2659ba2810a2")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_Obsolete_DisplayName")]
	Obsolete,
	[Uid("8da30e2f-5a91-42dd-9ee9-cc2e14715f46")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_Current_DisplayName")]
	Current,
	[Uid("04273d99-5773-4314-8073-8d1636bcd100")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_Deleted_DisplayName")]
	Deleted,
	[Uid("f41d21d4-7083-45ac-a3b8-e454420a9c2b")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_Signed_DisplayName")]
	Signed,
	[Uid("5d0036ad-9151-4cc6-bbd0-050da40119f3")]
	[DisplayName(typeof(__Resources_DocumentVersionStatus), "P_InArchive_DisplayName")]
	InArchive
}
