using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
internal class BankAccountFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (!(model is BankAccountModel bankAccountModel) || bankAccountModel.Entity == null || bankAccountModel.Entity.BankDetails == null || bankAccountModel.ViewType != ViewType.Display)
		{
			return formViewItem;
		}
		Guid bdUid = InterfaceActivator.PropertyUid((IBankAccount p) => p.BankDetails);
		FormViewItem form = ((ClassMetadata)MetadataLoader.LoadMetadata(EntityHelper.GetType(bankAccountModel.Entity.BankDetails), inherit: true, loadImplementation: false)).DefaultForms.GetForm(ViewType.Display);
		if (form == null)
		{
			return formViewItem;
		}
		List<Guid> bdDisplayFormItemUids = (from o in form.GetAllItems().OfType<PropertyViewItem>()
			select o.PropertyUid).ToList();
		return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IBankAccount> t)
		{
			(from i in formViewItem.GetAllItems().OfType<PropertyViewItem>()
				where i.PropertyUid == bdUid
				select i).Each(delegate(PropertyViewItem p)
			{
				List<Guid> list = (from i in p.Items.OfType<PropertyViewItem>()
					where !i.Hide
					select i into o
					select o.PropertyUid).ToList();
				if (list.Any())
				{
					foreach (Guid item in bdDisplayFormItemUids)
					{
						if (!list.Contains(item))
						{
							t.ForItem<PropertyViewItem>(p.Uid).Add(new PropertyViewItem
							{
								Uid = item,
								PropertyUid = item
							});
						}
					}
				}
			});
		});
	}
}
