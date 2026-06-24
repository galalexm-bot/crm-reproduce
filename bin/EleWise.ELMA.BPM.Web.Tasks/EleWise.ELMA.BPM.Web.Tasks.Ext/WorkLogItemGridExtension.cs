using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 10)]
public class WorkLogItemGridExtension : IDynamicGridExtension
{
	public bool MatchUniqueName(string uniqueName)
	{
		return uniqueName == "WorkLogItemGrid";
	}

	public void Apply<T>(DynamicGridBuilder<T> builder) where T : class
	{
		if (!(builder is DynamicGridBuilder<IWorkLogItem> dynamicGridBuilder))
		{
			return;
		}
		bool showDisplayName = (bool)(builder.Html.get_ViewData().get_Item("showDisplayName") ?? ((object)false));
		dynamicGridBuilder.Columns(delegate(DynamicColumnsBuilder<IWorkLogItem> c)
		{
			if (showDisplayName)
			{
				DynamicColumnBuilder<IWorkLogItem, bool> existingColumnBuilder = c.InsertAfter((IWorkLogItem m) => m.Status, (IWorkLogItem m) => true, displayOnlyWithExistingColumn: true).Template((IWorkLogItem t) => PartialExtensions.Partial(builder.Html, "Partial/WorkLogItemObjectIcon", (object)t, new ViewDataDictionary())).Sortable(sortable: false)
					.Width(16);
				c.InsertAfter(existingColumnBuilder, (IWorkLogItem m) => true, displayOnlyWithExistingColumn: true).Header(SR.T("Название")).Sortable(sortable: false)
					.Template((IWorkLogItem t) => PartialExtensions.Partial(builder.Html, "Partial/WorkLogItemDisplay", (object)t, new ViewDataDictionary()));
			}
			c.InsertBefore((IWorkLogItem m) => m.FactWorkTime, (IWorkLogItem m) => true, displayOnlyWithExistingColumn: true).Header(SR.T("План")).Template((IWorkLogItem t) => PartialExtensions.Partial(builder.Html, "DisplayTemplates/WorkTimeCompact", (object)WorkLogHelper.PlanWorkLog(t), new ViewDataDictionary()))
				.Sortable(sortable: false);
		});
	}
}
