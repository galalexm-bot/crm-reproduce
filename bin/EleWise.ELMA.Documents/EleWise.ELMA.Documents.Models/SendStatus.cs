using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("8e8d54f6-785d-408a-90a2-0127b72dff4f")]
[DisplayName(typeof(__Resources_SendStatus), "DisplayName")]
public enum SendStatus
{
	[Uid("ff261c66-7114-49f4-86a1-9a2c04a091d6")]
	[DisplayName(typeof(__Resources_SendStatus), "P_NotSended_DisplayName")]
	NotSended,
	[Uid("98c8481e-e470-46f7-ac6e-d654721ef42a")]
	[DisplayName(typeof(__Resources_SendStatus), "P_Sended_DisplayName")]
	Sended
}
