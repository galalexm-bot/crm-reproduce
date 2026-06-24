using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISystemCatalogChecker
{
	bool CantDelete(object entity);
}
