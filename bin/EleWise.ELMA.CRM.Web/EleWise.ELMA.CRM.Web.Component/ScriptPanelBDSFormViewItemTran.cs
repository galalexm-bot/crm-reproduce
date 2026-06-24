using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
internal class ScriptPanelBDSFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if (!formViewItem.IsReadOnly() && (model is BankDetailsSWIFTModel || (model is CatalogItemModel && (model as CatalogItemModel).Entity is IBankDetailsSWIFT)))
		{
			return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IBankDetailsSWIFT> t)
			{
				t.ForItem(formViewItem.Uid).Add(new PanelViewItem
				{
					CustomViewName = "ScriptPanelBDS"
				});
			});
		}
		return formViewItem;
	}
}
