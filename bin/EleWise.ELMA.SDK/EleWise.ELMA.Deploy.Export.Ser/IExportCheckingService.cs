using EleWise.ELMA.Deploy.Export.Models;

namespace EleWise.ELMA.Deploy.Export.Services;

public interface IExportCheckingService
{
	IExportCheckingResult Check(IExportCheckingContext context);
}
