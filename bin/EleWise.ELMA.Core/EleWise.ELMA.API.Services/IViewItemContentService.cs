using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[WebService("ViewItem", "SDK.Action")]
public interface IViewItemContentService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/GetViewItemContent")]
	System.Threading.Tasks.Task<HtmlWrapper> GetViewItemContent(ViewItemContentRequest request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/GetCustomViewItemContent")]
	System.Threading.Tasks.Task<HtmlWrapper> GetCustomViewItemContent(CustomViewItemContentRequest request);
}
