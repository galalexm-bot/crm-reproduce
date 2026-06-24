using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ISecurityCacheSetIdEventHandler : IEventHandler
{
	void PostCacheSet(SecurityCacheSetIdEventArgs args);
}
