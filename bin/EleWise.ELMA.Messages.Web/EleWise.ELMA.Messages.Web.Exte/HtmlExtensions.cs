using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.CustomMessagesPager;

namespace EleWise.ELMA.Messages.Web.Extensions;

public static class HtmlExtensions
{
	public static MvcHtmlString AuditObject(this HtmlHelper html, Guid uid)
	{
		IAuditManager service = Locator.GetService<IAuditManager>();
		return PartialExtensions.Partial(html, "DisplayTemplates/AuditObject", (object)service.GetObject(uid));
	}

	public static bool AuditObjectHasImage(this HtmlHelper html, Guid objectUid)
	{
		IAuditObject @object = Locator.GetService<IAuditManager>().GetObject(objectUid);
		if (@object != null && @object.MetadataImage != null)
		{
			return @object.MetadataImage.Data != null;
		}
		return false;
	}

	public static MvcHtmlString AuditAction(this HtmlHelper html, Guid objectUid, Guid actionUid)
	{
		IAuditManager service = Locator.GetService<IAuditManager>();
		IAuditObject @object = service.GetObject(objectUid);
		return PartialExtensions.Partial(html, "DisplayTemplates/AuditAction", (object)new KeyValuePair<IAuditObject, IAuditAction>(@object, service.GetAction(@object, actionUid)));
	}

	public static string HeaderByRoute(this HtmlHelper html)
	{
		if (html.IsSendedMessages())
		{
			return string.Empty;
		}
		string text = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request["BaseMessageFilter.ChannelId"];
		if (text != null)
		{
			return InformationChannelManager.Instance.Load(Convert.ToInt64(text)).DisplayName;
		}
		return SR.T("Сообщения");
	}

	public static bool IsChannelMessages(this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request["BaseMessageFilter.ChannelId"] != null;
	}

	public static bool IsSendedMessages(this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request["BaseMessageFilter.Sended"] != null;
	}

	public static bool IsNotifications(this HtmlHelper html)
	{
		if (!html.IsChannelMessages())
		{
			return !html.IsSendedMessages();
		}
		return false;
	}

	public static IEnumerable GetChannelsForSettings(this HtmlHelper html)
	{
		yield return new
		{
			Id = (long?)(-1L),
			Name = SR.T("Все сообщения")
		};
		foreach (IInformationChannel item in InformationChannelManager.Instance.FindAll())
		{
			yield return new { item.Id, item.Name };
		}
	}

	public static MvcHtmlString Pager(this HtmlHelper helper, ListChannelMessageParentModel model)
	{
		string text = new CustomMessagesPager(model.PagerSettings, model.ItemsCount, ((ControllerContext)helper.get_ViewContext()).get_HttpContext().Request, isDebug: false)
		{
			GridId = model.GridId
		}.ToString();
		if (!(text == string.Empty))
		{
			return MvcHtmlString.Create(text);
		}
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString DiscussionSender(this HtmlHelper helper, DiscussionSenderInfo model)
	{
		return PartialExtensions.Partial(helper, "ChannelMessage/DiscussionSender", (object)model);
	}

	public static MvcHtmlString SendChannelMessageScript(this HtmlHelper helper, SendChannelMessageScriptModel model)
	{
		return PartialExtensions.Partial(helper, "ChannelMessage/SendChannelMessageScript", (object)model);
	}

	public static MvcHtmlString SendChannelMessagePopup(this HtmlHelper helper)
	{
		return PartialExtensions.Partial(helper, "ChannelMessage/SendChannelMessagePopup");
	}
}
