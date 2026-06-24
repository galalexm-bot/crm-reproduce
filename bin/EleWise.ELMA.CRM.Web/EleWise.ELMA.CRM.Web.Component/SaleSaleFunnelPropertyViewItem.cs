using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleSaleFunnelPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((ISale m) => m.SaleFunnel);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			ISale sale = model as ISale;
			if (formViewItem.IsUid(new Guid("c0a539e1-a9e8-4c62-bf4f-c695a52360a3")) && sale != null && sale.SaleFunnel != null)
			{
				propertyViewItem.Attributes.EntityFilterProvider = SaleTypeFilterProvider.UID;
				propertyViewItem.Attributes.EntityFilterData = sale.SaleFunnel.Uid.ToString();
			}
		}
	}
}
