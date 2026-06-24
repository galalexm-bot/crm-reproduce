using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ICheckCanExport
{
	string CanExport();

	bool AdditionalActions();
}
