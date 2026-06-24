using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace Orchard.Owin;

public class Startup
{
	public void Configuration(IAppBuilder app)
	{
		AppBuilderUseExtensions.Use(app, (Func<IOwinContext, Func<Task>, Task>)delegate(IOwinContext context, Func<Task> next)
		{
			context.get_Response().get_Headers().Append("X-Generator", "Orchard");
			return next();
		});
	}
}
