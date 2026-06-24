using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("Phone", "EleWise.ELMA.CRM.Web")]
public interface IPhoneService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/IsReplacePhoneStringByLink")]
	System.Threading.Tasks.Task<string> IsReplacePhoneStringByLink();
}
