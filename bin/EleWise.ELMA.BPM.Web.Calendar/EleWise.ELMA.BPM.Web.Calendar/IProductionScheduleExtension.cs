using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IProductionScheduleExtension
{
	MvcHtmlString RenderOnIndex(HtmlHelper html, ProductionScheduleModel model);

	MvcHtmlString RenderOnList(HtmlHelper html, ProductionScheduleModel model);
}
