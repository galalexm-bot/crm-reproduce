using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuditableEventHandlerAsync : IAuditableEventHandler, IEventHandler
{
	Task PreprocessAsync(AuditableCancelEventArgs e, CancellationToken cancellationToken = default(CancellationToken));

	Task PostprocessAsync(AuditableEventArgs e, CancellationToken cancellationToken = default(CancellationToken));
}
