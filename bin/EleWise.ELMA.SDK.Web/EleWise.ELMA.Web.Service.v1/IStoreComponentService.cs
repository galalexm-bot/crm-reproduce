using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IStoreComponentService
{
	[OperationContract]
	[WebGet(UriTemplate = "/GetInstalledComponentManifests")]
	ManifestList GetInstalledComponentManifests();

	[OperationContract]
	[WebGet(UriTemplate = "/GetComponentPackages?componentId={componentId}")]
	PackageList GetComponentPackages(string componentId);
}
