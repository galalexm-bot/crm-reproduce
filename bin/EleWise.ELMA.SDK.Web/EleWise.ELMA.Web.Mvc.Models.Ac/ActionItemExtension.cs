using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

public static class ActionItemExtension
{
	public static IActionItem Copy(this IActionItem actionItem, IActionItem itemData)
	{
		if (actionItem == null)
		{
			return null;
		}
		actionItem = ClassSerializationHelper.CloneObject(itemData);
		return actionItem;
	}
}
