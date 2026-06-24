using System.Web;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IHttpContextAccessor
{
	HttpContextBase Current();
}
