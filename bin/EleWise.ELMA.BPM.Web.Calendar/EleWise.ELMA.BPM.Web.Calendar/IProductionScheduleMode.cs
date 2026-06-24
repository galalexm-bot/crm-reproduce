using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IProductionScheduleMode
{
	string Code { get; }

	string Name { get; }

	string Tooltip { get; }

	string IconUrl { get; }

	MvcHtmlString RenderView(HtmlHelper html, ProductionScheduleModel model);
}
