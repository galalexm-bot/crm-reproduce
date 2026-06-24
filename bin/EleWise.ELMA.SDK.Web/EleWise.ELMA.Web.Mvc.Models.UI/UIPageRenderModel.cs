using System;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class UIPageRenderModel
{
	public string DynamicFormId { get; set; }

	public Guid ContextGuid { get; set; }

	public PageContentDescriptor Descriptor { get; private set; }

	public IPageLoadViewModel ViewModel { get; private set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public UIPageRenderModel(PageLoadResultWrapper result)
	{
		Contract.ArgumentNotNull(result, "result");
		ViewModel = result.Result.ViewModel;
		Descriptor = result.Result.ViewModel.PageContentDescriptor;
		DynamicFormSettings = result.DynamicFormSettings;
		ContextGuid = InterfaceActivator.UID(ViewModel.Context.GetType());
		DynamicFormId = $"PageDynamicForm_{ContextGuid:N}_{new Random().Next(1000)}";
	}

	public void RenderToolbar(HtmlHelper html, string dynamicFormId)
	{
		if (ViewModel.View.Toolbar != null && ViewModel.View.Toolbar.Items.Count != 0)
		{
			ToolbarBuilder builder = html.Toolbar(ViewModel.View.Toolbar.Uid.ToString("N"));
			ViewModel.View.Toolbar.Items.OfType<Group>().ForEach(delegate(Group g)
			{
				RenderGroup(html, builder, g, dynamicFormId);
			});
		}
	}

	private void RenderGroup(HtmlHelper html, ToolbarBuilder builder, Group group, string dynamicFormId)
	{
		if (!group.Items.Any())
		{
			return;
		}
		builder.Group(group.Name ?? group.Uid.ToString("N")).Buttons(delegate(ToolbarButtonsBuilder bb)
		{
			group.Items.ForEach(delegate(ToolbarItem b)
			{
				RenderToolbarItem(html, bb, b, dynamicFormId);
			});
		});
	}

	private void RenderToolbarItem(HtmlHelper html, ToolbarButtonsBuilder builder, ToolbarItem item, string dynamicFormId)
	{
		if (item is Separator)
		{
			builder.Separator().Uid(item.Name ?? item.Uid.ToString("N")).If(item.SetVisible, delegate(ToolbarSeparatorBuilder b)
			{
				b.Visible(item.Visible);
			});
			return;
		}
		Button button = item as Button;
		if (button == null)
		{
			return;
		}
		ToolbarButtonBuilder toolbarButtonBuilder = builder.Button(item.Name ?? item.Uid.ToString("N")).If(item.SetVisible, delegate(ToolbarButtonBuilder b)
		{
			b.Visible(item.Visible);
		});
		if (!string.IsNullOrWhiteSpace(button.ActionTypeProviderId) && !string.IsNullOrWhiteSpace(button.ActionId))
		{
			IContentActionRegistry serviceNotNull = Locator.GetServiceNotNull<IContentActionRegistry>();
			IContentAction contentAction = ((!string.IsNullOrWhiteSpace(button.ActionTypeProviderId) && !string.IsNullOrWhiteSpace(button.ActionId)) ? serviceNotNull.Get(button.ActionTypeProviderId, button.ActionId) : null);
			if (contentAction != null && !contentAction.IsAvalilable(((ControllerContext)html.get_ViewContext()).get_RequestContext()))
			{
				contentAction = null;
			}
			if (contentAction != null)
			{
				((ControllerContext)html.get_ViewContext()).get_RouteData().Values["Button-id"] = dynamicFormId;
				toolbarButtonBuilder.Text(SR.T(contentAction.NameForLocalization)).Url(contentAction.GetHref(((ControllerContext)html.get_ViewContext()).get_RequestContext())).ToolTip(SR.T(contentAction.DescriptionForLocalization))
					.IconUrl(contentAction.GetImage((builder.ActionItem is ActionToolbarGroup) ? ObjectIconFormat.x32 : ObjectIconFormat.x16));
				toolbarButtonBuilder.ActionItem.ActionTypeProviderId = button.ActionTypeProviderId;
				toolbarButtonBuilder.ActionItem.ActionId = button.ActionId;
				contentAction.OnRender(html);
			}
		}
		if (!string.IsNullOrWhiteSpace(button.Text))
		{
			toolbarButtonBuilder.Text(button.Text);
		}
		if (!string.IsNullOrWhiteSpace(button.ToolTip))
		{
			toolbarButtonBuilder.ToolTip(button.ToolTip);
		}
		if (!string.IsNullOrWhiteSpace(button.ToolTipHeader))
		{
			toolbarButtonBuilder.ToolTipHeader(button.ToolTipHeader);
		}
		MetadataImage namedImage = ViewModel.Descriptor.FormDescriptor.Metadata.GetNamedImage(button.Uid.ToString());
		if (!string.IsNullOrWhiteSpace(button.IconUrl) && (namedImage == null || HostingEnvironment.VirtualPathProvider.FileExists(button.IconUrl)))
		{
			toolbarButtonBuilder.IconUrl(button.IconUrl);
		}
		else if (namedImage != null)
		{
			toolbarButtonBuilder.IconUrl(html.Url().FormImage((item.Parent is Group) ? ObjectIconFormat.x32 : ObjectIconFormat.x16, ViewModel.PageContentDescriptor.FormDescriptor, button.Uid.ToString()));
		}
		if (!string.IsNullOrWhiteSpace(button.ScriptName))
		{
			toolbarButtonBuilder.Click($"elma.dynamicForms.onChange(null, null, '{HttpUtility.JavaScriptStringEncode(button.ScriptName)}', $('#{dynamicFormId}'))");
		}
		else if (!string.IsNullOrWhiteSpace(button.Url))
		{
			toolbarButtonBuilder.Url(button.Url);
		}
		else if (!string.IsNullOrWhiteSpace(button.Click))
		{
			toolbarButtonBuilder.Click(button.Click);
		}
		toolbarButtonBuilder.Checked(button.Checked);
		if (!button.Items.Any())
		{
			return;
		}
		toolbarButtonBuilder.Buttons(delegate(ToolbarButtonsBuilder bb)
		{
			button.Items.ForEach(delegate(ToolbarItem b)
			{
				RenderToolbarItem(html, bb, b, dynamicFormId);
			});
		});
	}
}
