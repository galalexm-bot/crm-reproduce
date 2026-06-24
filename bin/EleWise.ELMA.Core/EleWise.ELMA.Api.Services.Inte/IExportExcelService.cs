using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("ExportExcel", "")]
public interface IExportExcelService
{
	[Operation(Method = WebMethod.POST, UriTemplate = "/ExportFromGrid")]
	System.Threading.Tasks.Task<ExportExcelResultDto> ExportFromGrid(ExportExcelDataFromGridDto data);

	[Operation(Method = WebMethod.POST, UriTemplate = "/ExportFromBlock")]
	System.Threading.Tasks.Task<ExportExcelResultDto> ExportFromBlock(ExportExcelDataFromBlockDto data);
}
