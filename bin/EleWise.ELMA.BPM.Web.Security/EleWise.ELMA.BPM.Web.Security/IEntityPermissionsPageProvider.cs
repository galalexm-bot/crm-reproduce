using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IEntityPermissionsPageProvider
{
	bool IsSupported(object entity);

	void CheckAccess(object entity);
}
