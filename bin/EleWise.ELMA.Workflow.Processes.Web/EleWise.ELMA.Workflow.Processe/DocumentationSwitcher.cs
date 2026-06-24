using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Workflow.Processes.Web.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class DocumentationSwitcher : IActionItemProvider
{
	public const string DocumentationSwitcherButtonUid = "workflow-documentation-switcher-button";

	public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem != null)
		{
			bool flag = htmlHelper.get_ViewData().get_Model() is DocumentationIndexModel;
			return new List<IActionItem>
			{
				new ActionButton
				{
					Uid = "documentation-processes-my",
					Text = SR.T("Мои процессы"),
					Url = htmlHelper.Url().Action("Index", "Documentation", (object)new
					{
						area = "EleWise.ELMA.Workflow.Processes.Web"
					}),
					IsChecked = flag
				},
				new ActionButton
				{
					Uid = "documentation-processes-full",
					Text = SR.T("Вся документация"),
					Url = htmlHelper.Url().Action("FullIndex", "Documentation", (object)new
					{
						area = "EleWise.ELMA.Workflow.Processes.Web"
					}),
					IsChecked = !flag
				}
			};
		}
		return Enumerable.Empty<IActionItem>();
	}

	public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
	{
		if (rootItem == null || rootItem.Uid != "workflow-documentation-switcher-button")
		{
			return;
		}
		foreach (IActionItem item in GetItems(rootItem, htmlHelper))
		{
			rootItem.Items.Add(item);
		}
	}
}
