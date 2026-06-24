using EleWise.ELMA.ComponentModel;
using NHibernate;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogItemSearchExtension
{
	void SetupCriteria(ICriteria criteria, IWorkLogItemSearchFilter filter);
}
