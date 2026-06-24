using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContractorSalesGridViewItemRenderer : ViewItemRendererBase<ContractorSalesGridViewItem>, ICountViewItemRenderer
{
	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		if (!CRMPermissionProvider.HasPermission(CRMPermissionProvider.SalesAccessPermission))
		{
			return MvcHtmlString.Empty;
		}
		return base.Render(html, viewItem, model);
	}

	public long? Count(object model, ICountViewItem viewItem)
	{
		ISaleFilter saleFilter = InterfaceActivator.Create<ISaleFilter>();
		saleFilter.Contractors.Add((IContractor)model);
		return SaleManager.Instance.Count(saleFilter);
	}
}
