using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Types.References;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("BinaryFiles", "SDK.Action")]
[ServiceContract]
public interface IBinaryFileService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/UploadStructuredAjax")]
	System.Threading.Tasks.Task<StructuredFileResponse> UploadStructuredAjax(StructuredFileFolder structuredFileFolder);
}
