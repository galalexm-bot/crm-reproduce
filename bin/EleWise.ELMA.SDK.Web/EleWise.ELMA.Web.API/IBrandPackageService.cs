using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EleWise.ELMA.Web.API;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
public interface IBrandPackageService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Get")]
	Stream Get();
}
