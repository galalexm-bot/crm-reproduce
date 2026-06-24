using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services;

[WebService("HtmlEditorElement", "ContentArea")]
public interface IHtmlStringContentService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/GetHtmlStringEditorContent")]
	System.Threading.Tasks.Task<HtmlWrapper> GetHtmlStringEditorContent(GetHtmlStringContentRequest request);

	[Operation(Method = WebMethod.POST, UriTemplate = "/GetHtmlStringDisplayContent")]
	System.Threading.Tasks.Task<HtmlWrapper> GetHtmlStringDisplayContent(GetHtmlStringContentRequest request);
}
