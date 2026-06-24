using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
internal class ScriptPanelBankAccountFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (!formViewItem.IsReadOnly() && (model is BankAccountModel || (model is CatalogItemModel && (model as CatalogItemModel).Entity is IBankAccount)))
		{
			return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IBankAccount> t)
			{
				t.ForItem(formViewItem.Uid).Add(new PanelViewItem
				{
					CustomViewName = "ScriptPanelBankAccount"
				});
			});
		}
		return formViewItem;
	}
}
