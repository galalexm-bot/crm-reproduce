using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
[Obsolete]
public class ContractorSalesTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(ContractorSalesTabViewItem);
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		if (!CRMPermissionProvider.HasPermission(CRMPermissionProvider.SalesAccessPermission))
		{
			return MvcHtmlString.Empty;
		}
		((TabViewItem)viewItem).CaptionViewName = "ViewItems/ContractorSalesTabCaption";
		return base.Render(html, viewItem, model);
	}
}
