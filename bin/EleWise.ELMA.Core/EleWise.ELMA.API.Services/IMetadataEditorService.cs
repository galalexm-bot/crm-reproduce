using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("MetadataEditor", "")]
public interface IMetadataEditorService
{
	[GlobalFunction("2c5dc0b3-141a-4e36-b6ed-75cc34b0bb97")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetadataHeader>> GetMetadataHeaders(bool withDrafts);

	[GlobalFunction("306ede4e-cd49-4720-8699-7b6bb0d34256")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetadataHeader>> LoadMetadataHeaders(LoadMetadataHeadersRequest[] updateRequests);

	[GlobalFunction("a0f365f4-1cb5-407b-bb0b-4a2d5bd2c565")]
	System.Threading.Tasks.Task<IMetadata> LoadDraftMetadataByTypeUid(Guid typeUid);

	[GlobalFunction("2bdd20f3-487e-441c-be6e-b857eeae0e47")]
	System.Threading.Tasks.Task<MetadataHeader> LoadDraftMetadataHeaderByTypeUid(Guid typeUid);

	[GlobalFunction("e4630b6f-815f-4b54-8f53-e9f4f15e4a8e")]
	System.Threading.Tasks.Task<EntityFormView> GetEntityForm(EntityFormRequest formRequest);

	[GlobalFunction("daa8fa69-83c3-4463-8796-2e0b0953764d")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<NamespaceMetadata>> GetNamespaceMetadata();

	[GlobalFunction("36f396f0-edc1-4591-b8fd-cd9e246419fc")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<NamespaceInfo>> GetNamespaceInfo();

	[GlobalFunction("756ea569-4b26-46b7-9eff-6b4111459ecd")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<EntityFormHeaderList>> GetEntityFormHeaders(Guid[] typeUids);
}
