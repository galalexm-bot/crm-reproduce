using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Components;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Workflow.ViewItems;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class ContextPropertyViewItemRenderer : ViewItemRenderer
{
	private const string callContextContextPropertyViewItemModelDataName = "ContextPropertyViewItemModel";

	private const string callContextContextPropertyViewItemHtmlFieldPrefixDataName = "ContextPropertyViewItemHtmlFieldPrefix";

	protected internal static object Model
	{
		get
		{
			return ContextVars.GetOrDefault<object>("ContextPropertyViewItemModel");
		}
		set
		{
			ContextVars.Set("ContextPropertyViewItemModel", value);
		}
	}

	protected internal static string HtmlFieldPrefix
	{
		get
		{
			return ContextVars.GetOrDefault<string>("ContextPropertyViewItemHtmlFieldPrefix");
		}
		set
		{
			ContextVars.Set("ContextPropertyViewItemHtmlFieldPrefix", value);
		}
	}

	public override bool? IsEmpty(ViewItem viewItem)
	{
		IEnumerable<IPropertyIsEmptyOrDefault> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPropertyIsEmptyOrDefault>();
		IMetadata metadata = MetadataLoader.LoadMetadata(Model.GetType());
		if (viewItem is PropertyViewItem propertyViewItem)
		{
			foreach (IPropertyIsEmptyOrDefault item in extensionPoints)
			{
				if (item.IsEmptyOrDefault(propertyViewItem, Model, metadata as EntityMetadata) == false)
				{
					return false;
				}
			}
		}
		return true;
	}

	public override bool CanRender(ViewItem viewItem)
	{
		if (!(viewItem.GetType() == typeof(ContextPropertyViewItem)) && !(viewItem.GetType() == typeof(ContextPropertyCaptionViewItem)) && !(viewItem.GetType() == typeof(ContextPropertyValueViewItem)))
		{
			return viewItem.GetType() == typeof(ContextPropertyDescriptionViewItem);
		}
		return true;
	}

	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return parentViewItem is ColumnViewItem;
	}

	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		PropertyViewItemRenderer.Adjust((PropertyViewItem)viewItem);
		yield return viewItem;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		return false;
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		object obj = Model ?? html.get_ViewData().get_Model();
		using (new ObjectViewData(html, html.get_ViewData(), obj, initialize: true))
		{
			string htmlFieldPrefix = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
			try
			{
				string htmlFieldPrefix2 = HtmlFieldPrefix;
				if (!string.IsNullOrEmpty(htmlFieldPrefix2))
				{
					html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix2);
				}
				return PartialExtensions.Partial(html, $"ViewItems/{viewItem.GetType().Name.Remove(0, 7)}", obj);
			}
			finally
			{
				html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlFieldPrefix);
			}
		}
	}
}
