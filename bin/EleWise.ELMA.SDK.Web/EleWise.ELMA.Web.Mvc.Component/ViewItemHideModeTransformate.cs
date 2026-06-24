using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
internal class ViewItemHideModeTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		ViewItem[] array = null;
		ViewItemHideMode hideMode = ViewItemControl<ViewItem, object, object>.HideMode;
		FormViewItemTransformation formViewItemTransformation = new FormViewItemTransformation
		{
			Uid = formViewItem.Uid
		};
		if ((hideMode & ViewItemHideMode.Modal) == ViewItemHideMode.Modal)
		{
			array = formViewItem.GetAllItems().ToArray();
			ViewItem[] array2 = array;
			foreach (ViewItem viewItem in array2)
			{
				if ((viewItem.HideMode & ViewItemHideMode.Modal) == ViewItemHideMode.Modal)
				{
					formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(viewItem.Uid));
				}
			}
		}
		if ((hideMode & ViewItemHideMode.Main) == ViewItemHideMode.Main)
		{
			if (array == null)
			{
				array = formViewItem.GetAllItems().ToArray();
			}
			ViewItem[] array2 = array;
			foreach (ViewItem viewItem2 in array2)
			{
				if ((viewItem2.HideMode & ViewItemHideMode.Main) == ViewItemHideMode.Main)
				{
					formViewItemTransformation.Items.Add(ViewItemTransformation.Hide(viewItem2.Uid));
				}
			}
		}
		return formViewItem.Transformate(formViewItemTransformation);
	}
}
