using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal.Projects;

[WebService("ProjectMetadataHead", "EleWise.ELMA.Projects.Web")]
public interface IProjectMetadataHeadService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/GetActiveProjectTypeUids")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Guid>> GetActiveProjectTypeUids();
}
