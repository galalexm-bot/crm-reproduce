using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IPreUploadFile
{
	void TransformFile(BinaryFile binaryFile);
}
