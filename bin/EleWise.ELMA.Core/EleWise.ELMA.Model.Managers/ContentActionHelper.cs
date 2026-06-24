namespace EleWise.ELMA.Model.Managers;

public static class ContentActionHelper
{
	public const string StartProcessProviderId = "EleWise.ELMA.Workflow.Processes.StartProcessProvider";

	public const string SaveEntitiesProviderId = "EleWise.ELMA.SDK.SaveEntitiesProvider";

	public const string FormActionsProviderId = "EleWise.ELMA.Web.Components.FormActionProvider";

	public const string PageLinkTypeProviderId = "EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider";

	public const string PageV2 = "configuration_pagev2";

	public static bool IsProcessAction(string actionTypeProviderId)
	{
		return actionTypeProviderId == "EleWise.ELMA.Workflow.Processes.StartProcessProvider";
	}

	public static bool IsFormAction(string actionTypeProviderId)
	{
		return actionTypeProviderId == "EleWise.ELMA.Web.Components.FormActionProvider";
	}

	public static bool IsPageAction(string actionTypeProviderId)
	{
		return actionTypeProviderId == "EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider";
	}

	public static bool IsSaveEntitiesAction(string actionTypeProviderId)
	{
		return actionTypeProviderId == "EleWise.ELMA.SDK.SaveEntitiesProvider";
	}

	public static string GetActionId(string actionId, string actionTypeProviderId)
	{
		if (!IsFormAction(actionTypeProviderId))
		{
			if (!IsProcessAction(actionTypeProviderId))
			{
				return actionId;
			}
			return "EleWise.ELMA.Workflow.Processes.StartProcessProvider";
		}
		return "EleWise.ELMA.Web.Components.FormActionProvider";
	}
}
