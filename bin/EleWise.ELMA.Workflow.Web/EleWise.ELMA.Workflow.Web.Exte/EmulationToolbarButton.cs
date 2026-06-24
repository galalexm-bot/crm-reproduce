using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Workflow.Web.Extensions;

public class EmulationToolbarButton : IActionItemProvider
{
	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && SessionVars.TryGetValue<bool>("isEmulation", out var value) && value)
		{
			IActionItem actionItem = GetItems(rootItem, htmlHelper).FirstOrDefault();
			if (actionItem != null)
			{
				rootItem.Items.Add(actionItem);
			}
		}
	}

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null && !(rootItem.Uid != "DefaultActionsToolbar") && SessionVars.TryGetValue<long>("EmulationUid", out var value))
		{
			ActionToolbarGroup actionToolbarGroup = new ActionToolbarGroup
			{
				Visible = true
			};
			actionToolbarGroup.Items.Insert(0, new ActionToolbarItem("toolbar-stop-emulation-button")
			{
				Text = SR.T("Прервать эмуляцию"),
				Visible = true,
				ToolTip = SR.T("Прервать эмуляцию"),
				Url = htmlHelper.Url().Action("TerminateEmulation", "ProcessStartEmulation", (object)new
				{
					area = "EleWise.ELMA.Workflow.Web",
					id = value
				})
			});
			yield return actionToolbarGroup;
		}
	}
}
