using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuditEventProvider
{
	void Notify(string eventName, IAuditEventArgs e);
}
