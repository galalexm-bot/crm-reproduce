using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IAssemblyLoadService
{
	[OperationContract]
	[WebGet(UriTemplate = "/LoadAssemblyList?loadFiles={loadFiles}")]
	AssemblyList LoadAssemblyList(bool loadFiles);
}
