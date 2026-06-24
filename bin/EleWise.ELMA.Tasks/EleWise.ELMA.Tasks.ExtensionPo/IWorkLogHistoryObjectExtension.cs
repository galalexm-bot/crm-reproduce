using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IWorkLogHistoryObjectExtension
{
	bool CanHandle(IEntity entity);

	bool Visible(EntityLastActionInfo entityInfo);
}
