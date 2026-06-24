using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleProductsGridViewItemRenderer : ViewItemRendererBase<SaleProductsGridViewItem>, ICountViewItemRenderer
{
	public long? Count(object model, ICountViewItem viewItem)
	{
		return ((IEnumerable<ISaleProduct>)((ISale)model).Products).Count((ISaleProduct p) => !p.IsDeleted);
	}
}
