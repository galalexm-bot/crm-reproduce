using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Runtime.NH;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IUnitOfWorkEventListener
{
	void OnStartUnitofWork(IUnitOfWork unitOfWork);

	void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities);

	void OnPostFlushUnitofWork(IUnitOfWork unitOfWork);

	void OnPreCommitUnitofWork(IUnitOfWork unitOfWork);

	void OnPostCommitUnitofWork(IUnitOfWork unitOfWork);

	void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork);

	void OnDisposeUnitofWork(IUnitOfWork unitOfWork);
}
