using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleFunnelReportModel
{
	public ISaleFunnel SaleFunnel { get; set; }

	public List<SaleFunnelReportInfo> SaleFunnelReportInfo { get; set; }
}
