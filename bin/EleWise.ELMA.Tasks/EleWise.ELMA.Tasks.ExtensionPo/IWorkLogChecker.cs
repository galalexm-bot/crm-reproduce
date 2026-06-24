using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogChecker
{
	bool Check(object element);
}
