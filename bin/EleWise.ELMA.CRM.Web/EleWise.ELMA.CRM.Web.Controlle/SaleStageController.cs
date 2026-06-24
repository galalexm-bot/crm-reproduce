using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class SaleStageController : BPMController<ISaleStage, long>
{
	protected ISaleStageFilter CreateFilter(long saleFunnelId)
	{
		return new InstanceOf<ISaleStageFilter>().New;
	}

	public JsonResult List(string text, long saleTypeId)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		int num = 1;
		SelectList data = new SelectList((IEnumerable)(from i in base.Manager.Find(CreateFilter(num), new FetchOptions(0, 100, null))
			select new
			{
				id = i.Id,
				text = i.Name
			} into i
			where !string.IsNullOrEmpty(i.text)
			orderby i.text
			select i).ToList(), "id", "text");
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return val;
	}

	[HttpGet]
	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("crm-admin-menu");
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult Grid(GridCommand command)
	{
		ICollection<ISaleStage> collection = SaleStageManager.Instance.FindAll();
		return (ActionResult)(object)((Controller)this).PartialView((object)collection);
	}

	public ActionResult ChangeGlobalOrder(long id, ListSortDirection direction)
	{
		List<ISaleStage> list = SaleStageManager.Instance.ChangeGlobalOrder(id, direction);
		return (ActionResult)(object)((Controller)this).PartialView("GridContent", (object)list);
	}
}
