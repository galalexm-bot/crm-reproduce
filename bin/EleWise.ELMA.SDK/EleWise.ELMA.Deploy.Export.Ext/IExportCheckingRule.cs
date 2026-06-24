using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Models;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExportCheckingRule
{
	IExportCheckingResult Check(IExportCheckingContext context);
}
