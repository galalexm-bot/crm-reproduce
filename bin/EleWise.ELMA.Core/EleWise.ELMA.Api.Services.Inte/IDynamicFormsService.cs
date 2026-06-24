using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Api.Services.Internal;

[ServiceContract]
[WebService("DynamicForms", "SDK.Action")]
public interface IDynamicFormsService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/OpenForm?newPopupId={newPopupId}&buttonUid={buttonUid}", BodyContentType = "application/x-www-form-urlencoded")]
	System.Threading.Tasks.Task<string> OpenForm(object model, string newPopupId, string buttonUid);
}
