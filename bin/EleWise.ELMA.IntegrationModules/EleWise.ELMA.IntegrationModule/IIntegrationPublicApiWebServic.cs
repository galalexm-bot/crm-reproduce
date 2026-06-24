using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.IntegrationModules.API;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation("SR.M('Сервис для обработки внешних событий интеграции')")]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IIntegrationPublicApiWebService
{
	[OperationContract]
	[WebGet(UriTemplate = "/ExecuteExternalEvent?eventUrl={eventUrl}")]
	[WsdlDocumentation("SR.M('Выполнить внешнее событие')")]
	[return: WsdlParamOrReturnDocumentation("SR.M('Выполнено внешнее событие')")]
	bool ExecuteExternalEvent([WsdlParamOrReturnDocumentation("SR.M('Модель группы задач ознакомления')")] string eventUrl);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ExecuteExternalEventPOST?eventUrl={eventUrl}")]
	[WsdlDocumentation("SR.M('Выполнить внешнее событие')")]
	[return: WsdlParamOrReturnDocumentation("SR.M('Выполнено внешнее событие')")]
	bool ExecuteExternalEventPOST([WsdlParamOrReturnDocumentation("SR.M('Модель группы задач ознакомления')")] string eventUrl, [WsdlParamOrReturnDocumentation("SR.M('Данные для выполнения')")] WebData data);
}
