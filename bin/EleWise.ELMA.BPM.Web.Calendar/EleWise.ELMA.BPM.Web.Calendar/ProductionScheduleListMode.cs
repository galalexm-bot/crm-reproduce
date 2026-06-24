using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Calendar.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component(Order = 100)]
public class ProductionScheduleListMode : IProductionScheduleMode
{
	public string Code => "list";

	public string Name => SR.T("Список");

	public string Tooltip => SR.T("Календарь в виде списка");

	public string IconUrl => "#calendar_list.svg";

	public MvcHtmlString RenderView(HtmlHelper html, ProductionScheduleModel model)
	{
		return PartialExtensions.Partial(html, "List", (object)model);
	}
}
