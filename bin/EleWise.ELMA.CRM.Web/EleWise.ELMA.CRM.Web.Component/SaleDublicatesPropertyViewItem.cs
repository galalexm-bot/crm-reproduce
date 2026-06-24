using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleDublicatesPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((ISale m) => m.Dublicates);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			ISale sale = model as ISale;
			if (formViewItem.IsUid(new Guid("8c723a7f-5e62-4f73-ba7e-c1f9e9ca3b06")) && sale != null && (sale.Dublicates == null || ((ICollection<ILead>)sale.Dublicates).Count == 0))
			{
				propertyViewItem.Hide = true;
			}
		}
	}
}
