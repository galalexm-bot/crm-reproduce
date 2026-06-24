using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class SaleFunnelReportFilterModel : EntityModel<ISaleFunnel>
{
	public FilterModel DataFilter { get; set; }
}
