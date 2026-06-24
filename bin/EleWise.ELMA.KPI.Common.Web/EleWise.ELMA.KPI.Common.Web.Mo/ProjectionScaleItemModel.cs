using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.KPI.Common.Web.Models;

public class ProjectionScaleItemModel : FormViewModel
{
	public IProjectionScaleItem Entity { get; set; }

	public string ScaleId { get; set; }
}
