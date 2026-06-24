using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.Models;

internal interface ILinkedExportCheckingContext
{
	ExportCheckingMessageType? DefaultExportLinkChecking { get; set; }

	LinkedObjectsSearchParams SearchParams { get; set; }
}
