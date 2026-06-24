using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Mobile.API.Internal.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Common.Mobile.API.Internal;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IHistoryLoaderService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Load/{typeUid}/{entityId}")]
	WebData Load(string typeUid, string entityId, GetEntityHistoryRequest historyRequest);

	WebData Load(Guid typeUid, long entityId, IGetEntityHistoryRequest historyRequest);
}
