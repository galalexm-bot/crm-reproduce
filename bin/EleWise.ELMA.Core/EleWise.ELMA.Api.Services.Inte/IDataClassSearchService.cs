using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("DataClassMetadata", "")]
public interface IDataClassSearchService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/GetComponentHeaderUid")]
	System.Threading.Tasks.Task<Guid> GetComponentHeaderUid(SearchComponentHeaderRequestDto model);
}
