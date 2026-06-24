using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAuditEventPermissionChecker
{
	bool HasPermission(EntityActionEventArgs args);
}
