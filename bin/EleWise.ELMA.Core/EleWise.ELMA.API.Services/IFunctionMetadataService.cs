using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("FunctionMetadata", "")]
public interface IFunctionMetadataService
{
	[GlobalFunction("db0f2064-9907-4472-88db-b305fb5b9400")]
	System.Threading.Tasks.Task<FunctionMetadataItemHeader> Create(CreateModel createModel);

	[GlobalFunction("cfecdb2d-89b9-4f18-8f9f-f43afe325cd1")]
	System.Threading.Tasks.Task<FunctionMetadataItemHeader> EditHeader(CreateModel editModel);

	[GlobalFunction("74391a9a-cda8-4dc7-aee2-928b2560fe0a")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FunctionMetadataItemHeader>> LoadAll();

	[GlobalFunction("052e1981-4d67-4551-8699-e1217f1a0f3f")]
	System.Threading.Tasks.Task<FunctionMetadataItem> Load(Guid uid);

	[GlobalFunction("1a4823de-f6b1-4bae-a84a-d1b8bbf4f537")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FunctionMetadataItem>> LoadByUids(Guid[] uids);

	[GlobalFunction("8218cd2f-d60b-4811-80ec-78139cd69a3b")]
	System.Threading.Tasks.Task<FunctionSaveResult> Save(FunctionMetadataItem metadata);

	[GlobalFunction("c5be8840-c946-4f6c-b144-4b4fa13b4b4a")]
	System.Threading.Tasks.Task<FunctionMetadataPublishResult> Publish(Guid headerUid);

	[GlobalFunction("9cb20ffc-29e7-4e6d-ac5d-c910e43ec63d")]
	System.Threading.Tasks.Task Delete(Guid headerUid);

	[GlobalFunction("3dbdab71-01e3-4a3e-a147-1150b03b9f96")]
	System.Threading.Tasks.Task<FunctionMetadataItemHeader> Copy(Guid headerUid);

	[GlobalFunction("2524150a-5244-4d28-ba69-1e1ceaba05b5")]
	System.Threading.Tasks.Task<GenerateFunctionCodeResponse> GenerateCode(GenerateFunctionCodeRequest request);
}
