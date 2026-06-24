using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Actions;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Security.Actions;

[Component(EnableInterceptiors = false, InjectProerties = false)]
public class UserActionsProvider : IContentDispatchActionProvider
{
	[NotNull]
	private readonly Func<IUser, ActionRoute> _getBlockRoute;

	[NotNull]
	private readonly Func<IUser, ActionRoute> _getUnBlockRoute;

	public UserActionsProvider()
	{
		_getBlockRoute = (IUser u) => new ActionRoute("BlockUser", "User", new RouteValueDictionary
		{
			{ "id", u.Id },
			{ "area", "EleWise.ELMA.BPM.Web.Security" }
		});
		_getUnBlockRoute = (IUser u) => new ActionRoute("UnBlockUser", "User", new RouteValueDictionary
		{
			{ "id", u.Id },
			{ "area", "EleWise.ELMA.BPM.Web.Security" }
		});
	}

	public IEnumerable<IContentDispatchAction> GetActions(DispatchActionBuilder builder)
	{
		yield return builder.ForAction<UserManager, IUser>((UserManager m) => m.Block).MapHrefRoute((IUser u) => _getBlockRoute(u)).MapOnClickRoute((IUser u) => _getBlockRoute(u))
			.OnRender(delegate(HtmlHelper html, IUser u)
			{
				html.RegisterContent("BlockUserActionContent", delegate
				{
					IBlockUserModel blockUserModel = InterfaceActivator.Create<IBlockUserModel>();
					blockUserModel.BlockUser = u;
					return PartialExtensions.Partial(html, "User/BlockUserActionProvider", (object)blockUserModel);
				});
			})
			.ScriptMethodName("OpenBlockUserActionPopup")
			.ContentAction;
		yield return builder.ForAction<UserManager, IUser>((UserManager m) => m.UnBlock).MapHrefRoute((IUser u) => _getUnBlockRoute(u)).MapOnClickRoute((IUser u) => _getUnBlockRoute(u))
			.OnRender(delegate(HtmlHelper html, IUser u)
			{
				html.RegisterContent("UnBlockUserHiddenFormContent", (dynamic d) => html.EmptyFormAction(_getUnBlockRoute(u), "UnBlockUserHiddenForm"));
			})
			.UsePost("UnBlockUserHiddenForm")
			.ContentAction;
	}
}
