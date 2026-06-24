using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Files;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPrepareFileToDownload
{
	bool Check(BinaryFile file);

	BinaryFile Prepare(BinaryFile file);
}
