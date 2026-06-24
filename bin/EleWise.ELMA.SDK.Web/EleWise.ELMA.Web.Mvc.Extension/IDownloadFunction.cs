using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Transient, ComponentType.All)]
public interface IDownloadFunction
{
	bool IsSupported(BinaryFile file);

	string FunctionName(BinaryFile file);

	string GetData(BinaryFile file);
}
