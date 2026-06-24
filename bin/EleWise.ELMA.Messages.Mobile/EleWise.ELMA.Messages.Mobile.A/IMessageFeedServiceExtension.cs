using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Messages.Mobile.API.Interfaces;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
[WsdlDocumentation(typeof(MessageFeedServiceExtensionResources), "Description")]
internal interface IMessageFeedServiceExtension
{
	[OperationContract]
	[WebGet(UriTemplate = "/Posts/{objectId}?objectUid={objectUid}&recipient={recipient}")]
	[WsdlDocumentation(typeof(MessageFeedServiceExtensionResources), "GetPostDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(MessageFeedServiceExtensionResources), "FeedPostDescription")]
	FeedPost GetPost([WsdlParamOrReturnDocumentation(typeof(MessageFeedServiceExtensionResources), "ParentObjectIdDescription")] string objectId, [WsdlParamOrReturnDocumentation(typeof(MessageFeedServiceExtensionResources), "ParentObjectUidDescription")] string objectUid, [WsdlParamOrReturnDocumentation(typeof(MessageFeedServiceExtensionResources), "RecipientIdDescription")] string recipient);
}
