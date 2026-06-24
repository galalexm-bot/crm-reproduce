using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFormDescriptorPermissionChecker
{
	bool CanCheckPermission(Permission permission, FormDescriptor descriptor);

	bool HasPermission(Permission permission, FormDescriptor descriptor);
}
