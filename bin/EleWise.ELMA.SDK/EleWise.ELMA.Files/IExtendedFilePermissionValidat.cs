using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Files;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IExtendedFilePermissionValidator
{
	bool HasPermission(BinaryFile file, out string errorMessage);
}
