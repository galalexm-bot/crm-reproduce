using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface ISystemMetadataService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/GetSystemInitData")]
	SystemInitData GetSystemInitData(InitDataModel initDataModel);
}
