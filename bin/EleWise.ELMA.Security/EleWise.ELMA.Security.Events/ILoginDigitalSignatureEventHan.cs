using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Audit;

namespace EleWise.ELMA.Security.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ILoginDigitalSignatureEventHandler : IEventHandler
{
	void CheckDigitalSignature(LoginAuditContainer auditСontainer);
}
