using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata;

[MetadataType(typeof(EnumMetadata))]
[Uid("6bca7871-a483-4db7-bbbe-1ba839df0cbc")]
[ShowInTypeTree(false)]
[DisplayName(typeof(__Resources_HierarchyType), "DisplayName")]
[ShowInDesigner(false)]
public enum HierarchyType
{
	[DisplayName(typeof(__Resources_HierarchyType), "P_GroupAndElements_DisplayName")]
	[Uid("8554aca4-afd0-4568-804c-a648335ffa99")]
	GroupAndElements,
	[DisplayName(typeof(__Resources_HierarchyType), "P_Elements_DisplayName")]
	[Uid("0038656c-c769-425a-9940-bcb55023a38b")]
	Elements
}
