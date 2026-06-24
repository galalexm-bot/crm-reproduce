using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Calendar.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

public static class ProductionScheduleExtensions
{
	public static ToolbarGroupBuilder AddModeButtons(this ToolbarGroupBuilder builder, UrlHelper urlHelper, ProductionScheduleModel model)
	{
		if (model.AvailableModes.Count() > 1)
		{
			foreach (IProductionScheduleMode availableMode in model.AvailableModes)
			{
				string url = ((model.Entity.Uid == CalendarConstants.GlobalProductionScheduleEntityUid) ? urlHelper.Action("GlobalProductionSchedule", "ProductionSchedule", (object)new
				{
					modeCode = availableMode.Code
				}) : urlHelper.Action("Execute", "ProductionSchedule", (object)new
				{
					id = model.Entity.Id,
					modeCode = availableMode.Code
				}));
				builder.ToolbarButton(new ActionToolbarItem("view-type-" + availableMode.Code)
				{
					Text = availableMode.Name,
					IconUrl = availableMode.IconUrl,
					Checked = (model.CurrentMode == availableMode),
					Url = url,
					ToolTip = availableMode.Tooltip
				});
			}
			return builder;
		}
		return builder;
	}

	public static MvcHtmlString RenderSimpleModeBaseConfig(HtmlHelper htmlHelper, ConfigDataModel baseConfig, ViewDataDictionary viewData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(viewData);
		val.Add("area", (object)"EleWise.ELMA.BPM.Web.Calendar");
		return PartialExtensions.Partial(htmlHelper, "ProductionSchedule/Base/SimpleModeBaseConfig", (object)baseConfig, val);
	}
}
