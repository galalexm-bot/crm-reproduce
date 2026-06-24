using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("8379a78e-5589-47d4-8746-abf8727e6157")]
[DisplayName(typeof(__Resources_FolderType), "DisplayName")]
public enum FolderType
{
	[Uid("8b57d153-6f99-4284-a71c-01bb82b48162")]
	[DisplayName(typeof(__Resources_FolderType), "P_SharedFolder_DisplayName")]
	SharedFolder = 0,
	[Uid("28b720e8-5572-4631-9184-8fefa951e92b")]
	[DisplayName(typeof(__Resources_FolderType), "P_MyDocuments_DisplayName")]
	MyDocuments = 1,
	[Uid("413f9f1a-b75b-4158-943c-405a2e85538a")]
	[DisplayName(typeof(__Resources_FolderType), "P_Favorites_DisplayName")]
	Favorites = 2,
	[Uid("769bd6e8-c2a8-47b2-a1c8-dd83bc7d4cd1")]
	[DisplayName(typeof(__Resources_FolderType), "P_Manual_DisplayName")]
	Manual = 4
}
