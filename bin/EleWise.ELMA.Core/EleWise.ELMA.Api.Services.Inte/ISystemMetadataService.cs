using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("SystemMetadata", "")]
internal interface ISystemMetadataService
{
	[GlobalFunction("98fa76d5-9fe3-4dd5-8121-a0489c20f098")]
	System.Threading.Tasks.Task<object[]> GetSystemMetadata(Guid[] systemModules);

	[Operation(Method = WebMethod.POST, UriTemplate = "/GetSystemInitData")]
	System.Threading.Tasks.Task<SystemInitData> GetSystemInitData(InitDataModel initDataModel);
}
