using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPermissionManagmentServiceExtension
{
	Permission GetPermissionForBase(Permission permission, ClassMetadata metadata);
}
