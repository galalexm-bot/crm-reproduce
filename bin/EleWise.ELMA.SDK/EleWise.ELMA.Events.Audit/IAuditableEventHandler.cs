using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuditableEventHandler : IEventHandler
{
	void Preprocess(AuditableCancelEventArgs e);

	void Postprocess(AuditableEventArgs e);
}
