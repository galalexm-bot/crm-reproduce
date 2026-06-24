using System.Web;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IUserAuthenticationChecker
{
	bool Check(HttpContextBase httpContext, IUser user);
}
