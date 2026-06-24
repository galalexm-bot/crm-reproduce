using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementTaskDoCompletedAction
{
	void DoCompleted(IReplacementTask task, IUser sourceUser, ICollection<IUser> targetUsers, IEntity entity);
}
