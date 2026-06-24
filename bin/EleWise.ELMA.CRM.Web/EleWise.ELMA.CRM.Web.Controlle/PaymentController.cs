using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.SalesPlan;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class PaymentController : BPMController<IPayment, long>
{
	[HttpPost]
	public ActionResult Create(PaymentModel model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		model.Save();
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			success = true
		});
		return (ActionResult)val;
	}
}
