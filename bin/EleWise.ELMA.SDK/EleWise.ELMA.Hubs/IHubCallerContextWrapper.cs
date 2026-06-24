using System.Collections.Generic;
using System.Security.Principal;

namespace EleWise.ELMA.Hubs;

public interface IHubCallerContextWrapper
{
	string ConnectionId { get; }

	IDictionary<string, ICookieWrapper> RequestCookies { get; }

	INameValueCollectionWrapper Headers { get; }

	INameValueCollectionWrapper QueryString { get; }

	IPrincipal User { get; }

	IRequestWrapper Request { get; }
}
