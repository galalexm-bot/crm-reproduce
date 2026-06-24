using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleChangeStageModel : FormViewModel
{
	public long EntityId { get; set; }

	public string PopupId { get; set; }

	public string Comment { get; set; }

	public ISaleStage Stage { get; set; }

	public string ShortStatus { get; set; }

	public bool Break { get; set; }
}
