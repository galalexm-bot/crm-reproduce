using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class DynamicGridExtension
{
	public static void ReplacementProperties<T>(this DynamicColumnsBuilder<T> columnsBuilder, IReplacementTask replacementTask) where T : class, IEntity
	{
		foreach (IReplacementTaskGridPropertySettings extensionPoint in ComponentManager.Current.GetExtensionPoints<IReplacementTaskGridPropertySettings>())
		{
			extensionPoint.RenderColumns(columnsBuilder, replacementTask);
		}
	}
}
