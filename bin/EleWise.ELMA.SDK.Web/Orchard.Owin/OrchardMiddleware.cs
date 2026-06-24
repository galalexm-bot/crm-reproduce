using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace Orchard.Owin;

public static class OrchardMiddleware
{
	public static IAppBuilder UseOrchard(this IAppBuilder app)
	{
		AppBuilderUseExtensions.Use(app, (Func<IOwinContext, Func<Task>, Task>)async delegate(IOwinContext context, Func<Task> next)
		{
			await ((context.get_Environment()["orchard.Handler"] as Func<Task>) ?? throw new ArgumentException("orchard.Handler can't be null"))();
		});
		return app;
	}
}
