using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IPackageChangesService), "PackageChangesDescription")]
public interface IPackageChangesService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/InitDataSets")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IPackageChangesService), "InitDataSetsDescriptionProp")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "InitDataSetsResultDescription")]
	bool InitDataSets([WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "InitDataSetsDataSetsParamDescription")] Guid[] dataSets);

	[OperationContract]
	[WebGet(UriTemplate = "/Changes?from={fromServerTime}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IPackageChangesService), "ChangesDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "ChangesResultDescription")]
	PackageChangesResponse Changes([WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "ChangesFromServerTimeParamDescription")] DateTime fromServerTime);

	[OperationContract]
	[WebGet(UriTemplate = "/Packages?pId={packageUid}&from={from}&length={length}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IPackageChangesService), "PackagesDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesResultDescription")]
	PackageBase[] Packages([WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesPackageUidParamDescription")] string packageUid, [WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesFromParamDescription")] int from, [WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesLengthParamDescription")] int length);

	[OperationContract]
	[WebGet(UriTemplate = "/PackagesCommit?pId={packageUid}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IPackageChangesService), "PackagesCommitDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesCommitResultDescription")]
	bool PackagesCommit([WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "PackagesCommitPackageUidDescription")] string packageUid);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Sync")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IPackageChangesService), "SyncDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "SyncResultDescription")]
	bool Sync([WsdlParamOrReturnDocumentation(typeof(__IPackageChangesService), "SyncChangesParamDescription")] PackageChangesSyncRequest changes);
}
