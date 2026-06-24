using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[CoreWebService("EntityChanges")]
internal interface IEntityChangesService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/Changes?type={typeUid}&from={fromServerDate}&q={eqlQuery}")]
	System.Threading.Tasks.Task<EntityChangesResponse> Changes(Guid typeUid, string fromServerDate, string eqlQuery);
}
