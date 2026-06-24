using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Ioc.Models;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Ioc.Resolvers;

internal sealed class LoggerResolverModule : RegistryModule
{
	public override void LoadModule(IRegistry registry)
	{
		registry.RegisterInstance(typeof(ILogger), (object)new ConsoleLogger());
	}
}
