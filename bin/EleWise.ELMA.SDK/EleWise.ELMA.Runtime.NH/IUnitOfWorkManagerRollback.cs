using System;

namespace EleWise.ELMA.Runtime.NH;

public interface IUnitOfWorkManagerRollback
{
	void RegisterRollbackAction(Action action);
}
