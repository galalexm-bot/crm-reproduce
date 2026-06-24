using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Content.Mvc;

public static class ToolbarBuilderExtensions
{
	public static ToolbarButtonBuilder ContentAction([NotNull] this ToolbarButtonsBuilder toolbarButtonsBuilder, string actionId)
	{
		if (toolbarButtonsBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonsBuilder");
		}
		IContentAction contentItem = Locator.GetServiceNotNull<IContentActionRegistry>().Get("ActionsLinkTypeProvider", actionId);
		return CreateBottonForContentItem(toolbarButtonsBuilder, contentItem, ObjectIconFormat.x16);
	}

	public static ToolbarGroupBuilder ContentAction([NotNull] this ToolbarGroupBuilder toolbarGroupBuilder, string actionId, Action<ToolbarButtonBuilder> buttonBuilder = null)
	{
		if (toolbarGroupBuilder == null)
		{
			throw new ArgumentNullException("toolbarGroupBuilder");
		}
		IContentActionRegistry serviceNotNull = Locator.GetServiceNotNull<IContentActionRegistry>();
		IContentAction contentItem = serviceNotNull.Get("ActionsLinkTypeProvider", actionId);
		toolbarGroupBuilder.Buttons(delegate(ToolbarButtonsBuilder buttonsBuilder)
		{
			ToolbarButtonBuilder obj = CreateBottonForContentItem(buttonsBuilder, contentItem, ObjectIconFormat.x32);
			if (buttonBuilder != null)
			{
				buttonBuilder(obj);
			}
		});
		return toolbarGroupBuilder;
	}

	public static ToolbarGroupBuilder ContentAction<TController>([NotNull] this ToolbarGroupBuilder toolbarGroupBuilder, Expression<Action<TController>> expression, Action<ToolbarButtonBuilder> buttonBuilder = null) where TController : Controller
	{
		if (toolbarGroupBuilder == null)
		{
			throw new ArgumentNullException("toolbarGroupBuilder");
		}
		ControllerActionRegistry serviceNotNull = Locator.GetServiceNotNull<ControllerActionRegistry>();
		ContentAction contentAction = serviceNotNull.Action(expression);
		toolbarGroupBuilder.Buttons(delegate(ToolbarButtonsBuilder buttonsBuilder)
		{
			ToolbarButtonBuilder obj = CreateBottonForContentItem(buttonsBuilder, contentAction, ObjectIconFormat.x32);
			if (buttonBuilder != null)
			{
				buttonBuilder(obj);
			}
		});
		return toolbarGroupBuilder;
	}

	public static ToolbarButtonBuilder ContentAction<TController>([NotNull] this ToolbarButtonsBuilder toolbarButtonsBuilder, Expression<Action<TController>> expression) where TController : Controller
	{
		if (toolbarButtonsBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonsBuilder");
		}
		ContentAction contentItem = Locator.GetServiceNotNull<ControllerActionRegistry>().Action(expression);
		return CreateBottonForContentItem(toolbarButtonsBuilder, contentItem, ObjectIconFormat.x16);
	}

	public static ToolbarButtonBuilder ContentAction([NotNull] this ToolbarButtonsBuilder toolbarButtonsBuilder, ActionRoute actionRoute)
	{
		if (toolbarButtonsBuilder == null)
		{
			throw new ArgumentNullException("toolbarButtonsBuilder");
		}
		ContentAction contentItem = Locator.GetServiceNotNull<ControllerActionRegistry>().Action(actionRoute);
		return CreateBottonForContentItem(toolbarButtonsBuilder, contentItem, ObjectIconFormat.x16);
	}

	private static ToolbarButtonBuilder CreateBottonForContentItem(ToolbarButtonsBuilder toolbarButtonsBuilder, IContentAction contentItem, ObjectIconFormat size)
	{
		if (contentItem == null)
		{
			return toolbarButtonsBuilder.Button(delegate(ToolbarButtonBuilder b)
			{
				b.Visible(isVisible: false);
			});
		}
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem(toolbarButtonsBuilder.HtmlHelper.GenerateName())
		{
			Text = contentItem.Name,
			IconUrl = contentItem.GetImage(size),
			ToolTip = contentItem.Description,
			OnRender = contentItem.OnRender
		};
		string href = contentItem.GetHref(((ControllerContext)toolbarButtonsBuilder.HtmlHelper.get_ViewContext()).get_RequestContext());
		if (href != null && href.StartsWith("javascript:"))
		{
			actionToolbarItem.Click = href.Replace("javascript:", "");
		}
		else
		{
			actionToolbarItem.Url = href;
		}
		return toolbarButtonsBuilder.AddItem(actionToolbarItem);
	}

	public static IActionItem CreateButton([NotNull] this IContentAction contentItem, HtmlHelper html)
	{
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem(html.GenerateName())
		{
			Text = contentItem.Name,
			IconUrl = contentItem.GetImage(ObjectIconFormat.x32),
			ToolTip = contentItem.Description,
			OnRender = contentItem.OnRender
		};
		string href = contentItem.GetHref(((ControllerContext)html.get_ViewContext()).get_RequestContext());
		if (href != null && href.StartsWith("javascript:"))
		{
			actionToolbarItem.Click = href.Replace("javascript:", "");
		}
		else
		{
			actionToolbarItem.Url = href;
		}
		return actionToolbarItem;
	}
}
