using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Events;

[ShowInTypeTree(false)]
[Uid("fe0e8526-76fd-4305-9e5f-53a960048dbe")]
[DisplayName(typeof(__Resources_EntityManagerEventType), "DisplayName")]
[ShowInDesigner(false)]
[MetadataType(typeof(EnumMetadata))]
public enum EntityManagerEventType
{
	[Uid("96cfee9d-7558-43b1-bf09-01c730594609")]
	[DisplayName(typeof(__Resources_EntityManagerEventType), "P_Loading_DisplayName")]
	Loading,
	[Uid("7b5b66c7-f7dd-4200-adab-44a161ee514d")]
	[DisplayName(typeof(__Resources_EntityManagerEventType), "P_Loaded_DisplayName")]
	Loaded
}
