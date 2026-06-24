using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class FormViewItemRenderer : ViewItemRendererBase<FormViewItem>
{
	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		if (!((FormViewItem)viewItem).IsValid(out var invalidItem))
		{
			throw new Exception(SR.T("Невозможно отрисовать форму, поскольку она содержит неправильный элемент {0}({1})", invalidItem.Uid, invalidItem.GetType()));
		}
		return base.Render(html, viewItem, model);
	}
}
