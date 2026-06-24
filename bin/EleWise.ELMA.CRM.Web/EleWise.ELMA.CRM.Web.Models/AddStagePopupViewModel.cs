using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class AddStagePopupViewModel : FormViewModel
{
	public ISaleStage Entity { get; set; }
}
