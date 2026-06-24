using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Files.Previews;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IPreviewExtendedFilePermissionValidator
{
	PreviewPermissionValidatorResult HasPermission(object containsEntity, BinaryFile file);
}
