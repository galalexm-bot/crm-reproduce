using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Models;

namespace EleWise.ELMA.IntegrationModules.ExtensionPoint;

[ExtensionPoint(ComponentType.All)]
public interface IExternalEventExecutor
{
	void Execute(ExternalEvent externalEvent, IIntegrationModule module);

	void Execute(ExternalEvent externalEvent, IIntegrationModule module, WebData data);
}
