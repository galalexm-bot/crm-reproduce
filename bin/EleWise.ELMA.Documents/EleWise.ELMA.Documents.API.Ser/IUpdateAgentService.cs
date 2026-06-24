using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Documents.API.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.Agent;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IUpdateAgentService
{
	[OperationContract]
	[WebGet(UriTemplate = "/CheckVersion?version={version}")]
	UpdateAgentInfo GetUpdateInfoString(string version);
}
