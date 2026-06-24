using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Transient, ComponentType.All)]
public interface IDownloadBinaryFunction
{
	void Execute(BinaryFile file);
}
