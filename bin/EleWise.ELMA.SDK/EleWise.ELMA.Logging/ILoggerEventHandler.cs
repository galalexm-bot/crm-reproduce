using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Logging;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ILoggerEventHandler
{
	event LogEventHandler Logged;
}
