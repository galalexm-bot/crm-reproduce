using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
internal class SecurityPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		switch (Locator.GetServiceNotNull<IPropertyPermissionService>().CheckPropertyPermission(model, propertyViewItem.PropertyUid))
		{
		case PropertyPermissionType.Hide:
			propertyViewItem.Hide = true;
			if (propertyViewItem.ReadOnly == true)
			{
				propertyViewItem.DynamicProperties.RemoveAll((ComputedValue a) => a.Name == "Hide");
			}
			break;
		case PropertyPermissionType.Read:
			propertyViewItem.Attributes.ReadOnly = true;
			if (propertyViewItem.ReadOnly == true)
			{
				propertyViewItem.DynamicProperties.RemoveAll((ComputedValue a) => a.Name == "ReadOnly");
			}
			break;
		}
	}
}
