using System;
using System.Data;

namespace EleWise.ELMA.Runtime.NH;

public interface IUnitOfWorkManager
{
	IUnitOfWork Create(string dbName, bool transactional, IsolationLevel isolationLevel = IsolationLevel.Unspecified);

	bool HasActiveTransaction(string dbName);

	void RollbackCurrent(string dbName);

	void RevertEntityChangesOnCommit(string dbName, object entity);

	void ThrowExceptionOnCommit(Exception ex);

	void RegisterPreCommitAction(Action action);

	void RegisterPostCommitAction(Action action);
}
