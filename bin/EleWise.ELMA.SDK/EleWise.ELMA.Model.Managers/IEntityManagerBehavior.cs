using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using NHibernate;

namespace EleWise.ELMA.Model.Managers;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IEntityManagerBehavior
{
	void OnCreateCriteria(ICriteria criteria, IEntityFilter filter);

	void OnLoad(object target);
}
