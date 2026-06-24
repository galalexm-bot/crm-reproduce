using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Cache;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICacheKeyFormatter
{
	string Format(string cacheKey, InvocationParameters invocation);
}
