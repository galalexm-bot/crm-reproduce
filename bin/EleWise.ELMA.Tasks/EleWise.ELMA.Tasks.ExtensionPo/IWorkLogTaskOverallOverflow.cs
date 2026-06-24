using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogTaskOverallOverflow
{
	bool CheckType(IEntity entity);

	ICollection<long> GetId(IEntity currentWorkLogObject);
}
