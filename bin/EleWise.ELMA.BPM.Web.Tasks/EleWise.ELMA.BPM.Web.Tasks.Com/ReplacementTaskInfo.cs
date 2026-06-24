using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(EnableInterceptiors = false, InjectProerties = false)]
internal class ReplacementTaskInfo : IExtensionZone
{
	private static readonly List<string> zones = new List<string> { "EleWise.ELMA.BPM.Web.Tasks.ReplacementTask.TableInfo" };

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zones.Contains(zoneId);
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zones.Contains(zoneId) && html.get_ViewData().get_Model() is TaskViewModel taskViewModel && taskViewModel.Entity is IReplacementTask replacementTask && replacementTask.IsReplacementTask())
		{
			RenderPartialExtensions.RenderPartial(html, "ReplacementTask/ReplacementTaskInfo", (object)replacementTask);
		}
	}
}
