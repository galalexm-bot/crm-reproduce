using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("063cf20d-b631-4b8e-b226-2e37408a137b")]
[DisplayName(typeof(__Resources_DocumentTemplateType), "DisplayName")]
[DefaultValueUid("434e6710-343e-41e0-a57a-ee8ebed1a3fd")]
public enum DocumentTemplateType
{
	[Uid("434e6710-343e-41e0-a57a-ee8ebed1a3fd")]
	[DisplayName(typeof(__Resources_DocumentTemplateType), "P_File_DisplayName")]
	File,
	[Uid("f28930a7-d353-4743-a5b1-842f6d8189e8")]
	[DisplayName(typeof(__Resources_DocumentTemplateType), "P_Document_DisplayName")]
	Document
}
