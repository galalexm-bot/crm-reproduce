using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuditEventProviderAsync : IAuditEventProvider
{
	Task NotifyAsync(string eventName, IAuditEventArgs e, CancellationToken cancellationToken = default(CancellationToken));
}
