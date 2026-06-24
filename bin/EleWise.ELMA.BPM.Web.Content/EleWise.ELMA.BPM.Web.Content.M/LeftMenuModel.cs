using System;
using System.Web;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class LeftMenuModel
{
	public LeftMenuRenderOptions Options { get; set; }

	public MenuModel MenuModel { get; private set; }

	public string MenuId { get; private set; }

	public bool IsMobile { get; private set; }

	[Obsolete("Больше не используется")]
	public bool Collapsed { get; private set; }

	[Obsolete("Больше не используется")]
	public int ExpandedWidth { get; private set; }

	[Obsolete("Больше не используется")]
	public int Width { get; private set; }

	public LeftMenuModel(MenuModel menuModel, HttpContextBase context)
		: this(menuModel, context, new LeftMenuRenderOptions())
	{
	}

	public LeftMenuModel(MenuModel menuModel, HttpContextBase context, LeftMenuRenderOptions options)
	{
		if (menuModel == null)
		{
			throw new ArgumentNullException("menuModel");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		MenuModel = menuModel;
		if (options == null)
		{
			options = new LeftMenuRenderOptions();
		}
		Options = options;
		IsMobile = context.Request.UserAgent.Contains("Mobile");
		MenuId = "/menu/" + menuModel.MenuUid;
		MenuState menuState = StateExtensions.LoadState<MenuState>(MenuId);
		if (menuState == null)
		{
			menuState = new MenuState
			{
				Id = MenuId,
				Collapsed = true,
				Width = options.MinWidth
			};
			StateExtensions.SaveState(MenuId, menuState);
		}
		if (menuState.Width < options.MinWidth)
		{
			menuState.Width = options.MinWidth;
		}
		if (menuState.Width > options.MaxWidth)
		{
			menuState.Width = options.MaxWidth;
		}
		Collapsed = menuState.Collapsed;
		if (IsMobile)
		{
			HttpCookie httpCookie = context.Request.Cookies[options.CollapseCookie];
			Collapsed = httpCookie == null || httpCookie.Value == "1";
		}
		ExpandedWidth = menuState.Width;
		Width = (Collapsed ? options.CollapsedWidth : ExpandedWidth);
	}
}
