using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

[Obsolete("Не используйте данный интерфейс, т.к. в дальнейшем он будет удален", false)]
public interface ITaskBaseManager
{
	ITaskBaseManager GetImplManager(Type entityType);

	bool? CanStartReAssign(ITaskBase task, IUser userToStart);

	bool? IsAvailableCopy(ITaskBase task);

	bool CanComplete(ITaskBase task, IUser user);
}
