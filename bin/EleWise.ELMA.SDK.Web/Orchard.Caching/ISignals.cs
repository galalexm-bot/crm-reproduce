namespace Orchard.Caching;

public interface ISignals : IVolatileProvider, ISingletonDependency, IDependency
{
	void Trigger<T>(T signal);

	IVolatileToken When<T>(T signal);
}
