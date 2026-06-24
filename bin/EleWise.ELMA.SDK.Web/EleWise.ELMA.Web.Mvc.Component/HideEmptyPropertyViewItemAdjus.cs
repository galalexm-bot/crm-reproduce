using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class HideEmptyPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object entity, ViewType viewType)
	{
		if (propertyViewItem.IsHideEmpty() && !propertyViewItem.Attributes.ShowEmpty && !propertyViewItem.Hide && (viewType == ViewType.Display || propertyViewItem.IsReadOnly() || propertyViewItem is PropertyCaptionViewItem || propertyViewItem is PropertyDescriptionViewItem))
		{
			ComponentManager.Current.GetExtensionPoints<IHideEmptyPropertyViewItemAdjustment>().FirstOrDefault((IHideEmptyPropertyViewItemAdjustment ep) => ep.IsApplicable(propertyViewItem, entity))?.Adjust(propertyViewItem, entity);
		}
	}
}
