using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Ioc.Models;

namespace EleWise.ELMA.Ioc.Resolvers;

internal sealed class LazyResolverModule : RegistryModule
{
	public override void LoadModule(IRegistry registry)
	{
		registry.RegisterGeneric(typeof(ILazy<>), typeof(Lazy<>));
	}
}
