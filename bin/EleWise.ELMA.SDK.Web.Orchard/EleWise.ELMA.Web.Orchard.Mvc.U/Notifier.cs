using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.UI;
using Newtonsoft.Json;
using Orchard.Localization;
using Orchard.UI.Notify;

namespace EleWise.ELMA.Web.Orchard.Mvc.UI;

[Service(Scope = ServiceScope.UnitOfWork)]
public class Notifier : EleWise.ELMA.Web.Mvc.UI.INotifier, IFormNotifier
{
	public const string HeaderKey = "MessagesListKey";

	private List<JsonConverter> converters = new List<JsonConverter> { (JsonConverter)(object)MvcHtmlStringJsonConverter.Instance };

	public global::Orchard.UI.Notify.INotifier Impl { get; set; }

	public ILogger Logger { get; set; }

	public IHttpContextAccessor HttpContextAccessor { get; set; }

	public Notifier()
	{
		Logger = NullLogger.Instance;
	}

	protected IEnumerable<NotifyEntry> GetStoredEntries(HtmlHelper html)
	{
		if (html == null || html.get_ViewContext() == null || html.get_ViewContext().get_TempData() == null || !html.get_ViewContext().get_TempData().ContainsKey("messages"))
		{
			return Enumerable.Empty<NotifyEntry>();
		}
		List<KeyValuePair<NotifyType, MvcHtmlString>> list = ClassSerializationHelper.DeserializeObjectByJsonNet<List<KeyValuePair<NotifyType, MvcHtmlString>>>(html.get_ViewContext().get_TempData().get_Item("messages")
			.ToString(), converters);
		if (list == null)
		{
			return Enumerable.Empty<NotifyEntry>();
		}
		List<NotifyEntry> list2 = new List<NotifyEntry>();
		foreach (KeyValuePair<NotifyType, MvcHtmlString> item in list)
		{
			list2.Add(new NotifyEntry
			{
				Type = item.Key,
				MvcStringMessage = item.Value
			});
		}
		return list2;
	}

	protected void AddMessage(NotifyType type, string message)
	{
		Impl.Add(type, new LocalizedString(message));
	}

	protected void AddMessage(NotifyType type, MvcHtmlString message)
	{
		Impl.Add(type, message);
	}

	public void Information(MvcHtmlString text)
	{
		Logger.Debug(SR.T("Информация: {0}", text));
		AddMessage(NotifyType.Information, text);
	}

	public void Warning(MvcHtmlString text)
	{
		Logger.Debug(SR.T("Предупреждение: {0}", text));
		AddMessage(NotifyType.Warning, text);
	}

	public void Error(MvcHtmlString text)
	{
		Logger.Debug(SR.T("Ошибка: {0}", text));
		AddMessage(NotifyType.Error, text);
	}

	public void RenderInPopup(MvcHtmlString text)
	{
		Logger.Debug(SR.T("Информация: {0}", text));
		AddMessage(NotifyType.RenderInPopup, text);
	}

	public void Information(string text)
	{
		Logger.Debug(SR.T("Информация: {0}", text));
		AddMessage(NotifyType.Information, text);
	}

	public void Warning(string text)
	{
		Logger.Debug(SR.T("Предупреждение: {0}", text));
		AddMessage(NotifyType.Warning, text);
	}

	public void Error(string text)
	{
		Logger.Debug(SR.T("Ошибка: {0}", text));
		AddMessage(NotifyType.Error, text);
	}

	public void RenderInPopup(string text)
	{
		Logger.Debug(SR.T("Информация: {0}", text));
		AddMessage(NotifyType.RenderInPopup, text);
	}

	public void HtmlAction(string action, string controller, RouteValueDictionary routeValues)
	{
		string text = NotifierHelper.WrapHtmlAction(action, controller, routeValues);
		Logger.Debug("HTML action:" + text);
		AddMessage(NotifyType.HtmlAction, text);
	}

	public MvcHtmlString Render(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Templates/NotifyMessages", (object)(from e in GetStoredEntries(html)
			orderby e.Type descending
			select e).ToList());
	}
}
