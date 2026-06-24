using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF")]
public class TreeMenuController : BPMController
{
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).Json((object)string.Format("[{{id:'0',text:'{0}'}}]", SR.T("Мои задачи")));
	}
}
