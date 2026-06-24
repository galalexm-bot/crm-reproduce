using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ProductFilterPropertyEditor : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (filterModel.Filter is ISaleFilter)
		{
			return property.PropertyUid == InterfaceActivator.PropertyUid((ISaleFilter p) => p.Products);
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		return null;
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
		a.TemplateName = "ProductFilterPropertyEditor";
	}
}
