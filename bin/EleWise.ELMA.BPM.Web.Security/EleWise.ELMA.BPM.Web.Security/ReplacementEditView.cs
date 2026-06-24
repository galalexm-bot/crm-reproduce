using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Panels;

namespace EleWise.ELMA.BPM.Web.Security.Components;

public class ReplacementEditView
{
	public static void ReplacementEditViewRender(HtmlHelper html, ReplacementModel model)
	{
		if (model == null)
		{
			return;
		}
		Dictionary<string, List<IReplacementEditViewExtension>> dictionary = (from m in ComponentManager.Current.GetExtensionPoints<IReplacementEditViewExtension>()
			group m by m.Id).ToDictionary((IGrouping<string, IReplacementEditViewExtension> m) => m.Key, (IGrouping<string, IReplacementEditViewExtension> m1) => m1.ToList());
		if (!dictionary.Any())
		{
			return;
		}
		foreach (string key in dictionary.Keys)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string item in from replacementEditExtension in dictionary[key]
				select ((HtmlString)(object)replacementEditExtension.Render(html, model)).ToHtmlString() into res
				where !string.IsNullOrWhiteSpace(res)
				select res)
			{
				stringBuilder.AppendLine(item);
			}
			if (stringBuilder.Length > 0)
			{
				IReplacementEditViewExtension replacementEditViewExtension = dictionary[key].First();
				CollapsiblePanel model2 = new CollapsiblePanel
				{
					Id = replacementEditViewExtension.Id,
					Header = replacementEditViewExtension.Name,
					SaveState = replacementEditViewExtension.SaveState,
					Expanded = replacementEditViewExtension.Expanded,
					Class = "separator-gray"
				};
				html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)html.CollapsiblePanelBegin(model2)).ToHtmlString());
				html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)html.TableFormStart(ViewType.Edit)).ToHtmlString());
				html.get_ViewContext().get_Writer().WriteLine(stringBuilder.ToString());
				html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)html.TableFormEnd()).ToHtmlString());
				html.get_ViewContext().get_Writer().WriteLine(((HtmlString)(object)html.CollapsiblePanelEnd(model2)).ToHtmlString());
			}
		}
	}
}
