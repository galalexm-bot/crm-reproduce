using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleContractorReadOnlyFunnelFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (!formViewItem.IsUid(new Guid("c0a539e1-a9e8-4c62-bf4f-c695a52360a3")))
		{
			return formViewItem;
		}
		if (!(model is SaleModel))
		{
			return formViewItem;
		}
		if (!(model as SaleModel).ContractorReadOnly)
		{
			return formViewItem;
		}
		Guid contractorPropertyUid = InterfaceActivator.PropertyUid((ISale m) => m.Contractor);
		return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<ISale> t)
		{
			(from p in formViewItem.GetAllItems().OfType<PropertyViewItem>()
				where p.PropertyUid == contractorPropertyUid
				select p).Each(delegate(PropertyViewItem p)
			{
				t.ForItem<PropertyViewItem>(p.Uid).SetPropertyValue((PropertyViewItem prop) => prop.Attributes.ReadOnly, true);
			});
			t.ForItem(formViewItem.Uid).Add(new PanelViewItem
			{
				CustomViewName = "ViewItems/SaleContractorId"
			});
		});
	}
}
