using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("ModuleMetadata", "")]
public interface IModuleMetadataService
{
	[GlobalFunction("68a7de40-fe46-43a8-ae51-b01ea30ede73")]
	System.Threading.Tasks.Task<ModuleMetadataItemHeader> Create(CreateModuleModel model);

	[GlobalFunction("e63ac484-99ed-4c6c-b335-e872b035ae84")]
	System.Threading.Tasks.Task<bool> AddReference(ReferencesToModule references);

	[GlobalFunction("ee41669d-c749-4080-a4c8-af47ad83ddf2")]
	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> LoadAll();

	[GlobalFunction("0c4eae23-6564-45f3-b143-73eb5c6c57b7")]
	System.Threading.Tasks.Task<ModuleMetadataItem> Load(Guid headerUid);

	[GlobalFunction("70033128-7384-48fa-9b47-66c32094f9df")]
	System.Threading.Tasks.Task<ModuleMetadataItem> Publish(Guid headerUid);

	[GlobalFunction("42f1bc3f-ad41-447e-afea-16acf3fff9e6")]
	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> GetDrafts();

	[GlobalFunction("7358cc95-96ec-48a3-b978-0cd911b10a1d")]
	System.Threading.Tasks.Task Delete(Guid moduleUid);

	[GlobalFunction("b1618129-3ae1-4429-b144-b7587e3d287b")]
	System.Threading.Tasks.Task<ModuleMetadataItemHeader> SaveHeader(ModuleMetadataItemHeader metadata);

	[GlobalFunction("7fa83bef-7f34-4dab-92ac-a3c8238018e5")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<string>> GetEditionTags();

	[Operation(Method = WebMethod.POST, UriTemplate = "/CheckDesignerModules")]
	System.Threading.Tasks.Task<CheckDesignerModuleResultDTO[]> CheckDesignerModules();
}
