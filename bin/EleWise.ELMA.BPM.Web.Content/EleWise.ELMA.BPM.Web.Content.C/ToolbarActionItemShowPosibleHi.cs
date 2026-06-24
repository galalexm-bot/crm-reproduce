using System;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class ToolbarActionItemShowPosibleHidden : IActionItemBuildPosibleHidden
{
	private IContextBoundVariableService ContextBoundVariableService => Locator.GetServiceNotNull<IContextBoundVariableService>();

	public bool BuildPosibleHidden(Type actionItemType)
	{
		return ContextBoundVariableService.GetOrAdd("ToolbarActionItemBuilderVisibility", () => WorkPlaceExtensions.CustomizerEnabled);
	}
}
