using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IReAssignActionHandler
{
	void BeforeCreateProcess(object task, IReAssignActionModel model);
}
