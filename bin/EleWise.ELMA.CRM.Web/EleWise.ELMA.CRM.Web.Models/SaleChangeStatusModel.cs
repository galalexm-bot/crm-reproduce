using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleChangeStatusModel : FormViewModel
{
	public long EntityId { get; set; }

	public string PopupId { get; set; }

	public string Comment { get; set; }

	public SaleStatus Status { get; set; }

	public string ShortStatus { get; set; }

	public bool Break { get; set; }
}
