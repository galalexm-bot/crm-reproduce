using System.Collections.Generic;

namespace Orchard.Owin;

public interface IOwinMiddlewareProvider : IDependency
{
	IEnumerable<OwinMiddlewareRegistration> GetOwinMiddlewares();
}
