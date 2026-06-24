using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IExportExcelService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ExportFromGrid")]
	ExportExcelResultDto ExportFromGrid(ExportExcelDataFromGridDto data);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ExportFromBlock")]
	ExportExcelResultDto ExportFromBlock(ExportExcelDataFromBlockDto data);
}
