using System;
using Owin;

namespace Orchard.Owin;

public class OwinMiddlewareRegistration
{
	public Action<IAppBuilder> Configure { get; set; }

	public string Priority { get; set; }
}
