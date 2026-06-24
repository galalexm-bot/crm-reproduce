using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContractorDublicatesPropertyViewItemAdjustment : IPropertyViewItemAdjustment, IPropertyViewItemAdjustmentRuntime2
{
	public void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType)
	{
		Guid guid = InterfaceActivator.PropertyUid((IContractor m) => m.Dublicates);
		if (!(propertyViewItem.PropertyUid != guid))
		{
			FormViewItem formViewItem = propertyViewItem.FormViewItem;
			IContractor contractor = model as IContractor;
			if (formViewItem.IsUid(new Guid("43452920-ec84-4f11-b3c2-4efaeb99540c")) && contractor != null && (contractor.Dublicates == null || ((ICollection<ILead>)contractor.Dublicates).Count == 0))
			{
				propertyViewItem.Hide = true;
			}
		}
	}
}
