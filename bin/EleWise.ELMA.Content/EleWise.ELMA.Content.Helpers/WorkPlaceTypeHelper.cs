using EleWise.ELMA.Content.Components;
using EleWise.ELMA.Content.ExtensionPoints;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.Content.Helpers;

public static class WorkPlaceTypeHelper
{
	public static IWorkPlaceType GetWorkPlaceType(this IWorkPlace workPlace)
	{
		return WorkPlaceManager.Instance.GetWorkPlaceType(workPlace?.Type ?? StandardWorkPlaceType.Uid);
	}
}
