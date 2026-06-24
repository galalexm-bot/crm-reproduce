using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContactContractorPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((IContact m) => m.Contractor);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			propertyViewItem.Attributes.EntityFilterProvider = ContactSupportFilterProvider.UID;
		}
	}
}
