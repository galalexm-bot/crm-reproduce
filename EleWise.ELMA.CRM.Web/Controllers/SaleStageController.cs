using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
  public class SaleStageController : BPMController<ISaleStage, long>
  {
    protected ISaleStageFilter CreateFilter(long saleFunnelId) => new InstanceOf<ISaleStageFilter>().New;

    public JsonResult List(string text, long saleTypeId)
    {
      SelectList selectList = new SelectList((IEnumerable) base.Manager.Find((IEntityFilter) this.CreateFilter(1L), new FetchOptions(0, 100, (string) null)).Select(i => new
      {
        id = i.Id,
        text = i.Name
      }).Where(i => !string.IsNullOrEmpty(i.text)).OrderBy(i => i.text).ToList(), "id", nameof (text));
      return new JsonResult() { Data = (object) selectList };
    }

    [HttpGet]
    public ActionResult Index()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View();
    }

    public ActionResult Grid(GridCommand command) => PartialView((object) SaleStageManager.Instance.FindAll());

    public ActionResult ChangeGlobalOrder(long id, ListSortDirection direction) => PartialView("GridContent", (object) SaleStageManager.Instance.ChangeGlobalOrder(id, direction));
  }
}
