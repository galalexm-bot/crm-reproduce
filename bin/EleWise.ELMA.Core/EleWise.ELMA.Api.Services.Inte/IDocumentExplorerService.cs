using System;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("FilterDocument", "Documents")]
public interface IDocumentExplorerService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/SearchDocumentPopup?popupUid={popupUid}&inputName={inputName}&typeUid={typeUid}&showOnlyGroups={showOnlyGroups}&entityFilterProvider={entityFilterProvider}&entityFilterData={entityFilterData}&popupWidth={popupWidth}&multiSelect={multiSelect}")]
	System.Threading.Tasks.Task<string> SearchDocumentPopup(Guid popupUid, string inputName, Guid typeUid, bool showOnlyGroups, string entityFilterProvider, string entityFilterData, int popupWidth, bool multiSelect);
}
