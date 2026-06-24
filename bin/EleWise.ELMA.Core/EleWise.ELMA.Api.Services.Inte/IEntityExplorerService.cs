using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("Entity", "Common")]
public interface IEntityExplorerService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/CreateEntityPopup?typeUid={typeUid}&popupUid={popupUid}&containerUid={containerUid}&inputId={inputId}")]
	System.Threading.Tasks.Task<string> CreateEntityPopup(Guid typeUid, Guid popupUid, Guid containerUid, string inputId);

	[Operation(Method = WebMethod.GET, UriTemplate = "/SearchEntityPopup?popupUid={popupUid}&inputName={inputName}&typeUid={typeUid}&showOnlyGroups={showOnlyGroups}&entityFilterProvider={entityFilterProvider}&entityFilterData={entityFilterData}&popupWidth={popupWidth}&multiSelect={multiSelect}")]
	System.Threading.Tasks.Task<string> SearchEntityPopup(Guid popupUid, string inputName, Guid typeUid, bool showOnlyGroups, string entityFilterProvider, string entityFilterData, int popupWidth, bool multiSelect);

	[Operation(Method = WebMethod.GET, UriTemplate = "/CheckAvailableCreators?typeUid={typeUid}&disableSecurity={disableSecurity}")]
	System.Threading.Tasks.Task<string> CheckAvailableCreators(Guid typeUid, bool disableSecurity);
}
