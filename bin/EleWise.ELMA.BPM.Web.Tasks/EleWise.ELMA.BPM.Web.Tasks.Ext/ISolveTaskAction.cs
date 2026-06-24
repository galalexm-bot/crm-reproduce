using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISolveTaskAction
{
	Guid ActionKey { get; }

	string ImageUrl { get; }

	string DisplayName { get; }

	bool CheckType(ITaskBase task);

	bool IsVisible(ITaskBase task, bool debugMode);

	void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings);

	string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings);

	bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings);

	void RenderPopups(HtmlHelper helper, bool debugMode);
}
