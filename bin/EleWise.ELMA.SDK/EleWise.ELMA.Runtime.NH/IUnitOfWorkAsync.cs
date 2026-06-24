using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH;

public interface IUnitOfWorkAsync : IUnitOfWork, IDisposable
{
	Task<bool> IsDirtyAsync { get; }

	Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));

	Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken));
}
