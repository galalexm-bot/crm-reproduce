using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("ComponentMetadata", "")]
public interface IComponentMetadataService
{
	[GlobalFunction("d7624463-941c-464d-a808-a36fe953c00d")]
	System.Threading.Tasks.Task<ComponentMetadataItem> Load(Guid uid);

	[GlobalFunction("bd128ba0-8dab-47da-839f-697880800767")]
	System.Threading.Tasks.Task<ComponentSaveResult> SaveAndUpdate(ComponentMetadataItem metadata);

	[GlobalFunction("1fe7ef7c-7771-4451-8d46-8d7c08214e7a")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<ComponentMetadataItemHistory>> LoadHistory(string headerUid);

	[GlobalFunction("3d178c9a-af63-4aac-9b97-1347b3abab5c")]
	System.Threading.Tasks.Task<bool> MarkAsNotWorking(Guid uid);

	[GlobalFunction("e4d50b08-7402-44a8-9cf7-66e84ea68c0e")]
	System.Threading.Tasks.Task<ComponentMetadataItem> LoadDraftByHeaderUid(Guid headerUid);

	[GlobalFunction("35198abe-4873-45c1-9146-ad6e67a6b493")]
	System.Threading.Tasks.Task<RuntimeResponse> LoadRuntimeMetadata(RuntimeModel model);

	[GlobalFunction("7f581183-f6ba-4669-ad74-0d1bfe559116")]
	System.Threading.Tasks.Task<CreateLocalDataClassResult> CreateLocalDataClass(Guid headerUid);

	[Operation(Method = WebMethod.GET, UriTemplate = "/FindComponent?headerUid={headerUid}&viewMode={viewMode}")]
	System.Threading.Tasks.Task<RecursiveComponentModelDto> FindComponent(Guid headerUid, InterfaceBuilderViewMode viewMode);

	[GlobalFunction("3ab9590c-f7ad-4036-82c7-8b1b5af4d593")]
	System.Threading.Tasks.Task<ComponentMetadataItem> LoadAsDraft(Guid uid);
}
