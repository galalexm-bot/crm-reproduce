using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Runtime.NH;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IUnitOfWorkEventListenerAsync : IUnitOfWorkEventListener
{
	Task OnPreFlushUnitOfWorkAsync(IUnitOfWorkAsync unitOfWork, IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken));

	Task OnPostFlushUnitOfWorkAsync(IUnitOfWorkAsync unitOfWork, CancellationToken cancellationToken = default(CancellationToken));

	Task OnPreCommitUnitOfWorkAsync(IUnitOfWorkAsync unitOfWork, CancellationToken cancellationToken = default(CancellationToken));

	Task OnPostCommitUnitOfWorkAsync(IUnitOfWorkAsync unitOfWork, CancellationToken cancellationToken = default(CancellationToken));

	Task OnPostRollbackUnitOfWorkAsync(IUnitOfWorkAsync unitOfWork, CancellationToken cancellationToken = default(CancellationToken));
}
