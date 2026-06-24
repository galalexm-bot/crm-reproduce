using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH;

public interface IUnitOfWorkManagerAsync : IUnitOfWorkManager
{
	IUnitOfWorkAsync CreateAsync(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified);

	void RegisterAsyncPreCommitAction(Func<CancellationToken, Task> action);

	void RegisterAsyncPostCommitAction(Func<CancellationToken, Task> action);

	void RegisterAsyncRollbackAction(Func<CancellationToken, Task> action);

	Task ThrowExceptionOnCommitAsync(Exception ex, CancellationToken cancellationToken = default(CancellationToken));
}
