using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Diagnostics.Serialization;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;
using Orchard.DisplayManagement;
using Orchard.Mvc.Filters;

namespace Orchard.UI.Notify;

public class NotifyFilter : FilterProvider, IActionFilter, IResultFilter
{
	private const string TempDataMessages = "messages";

	private readonly INotifier _notifier;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly dynamic _shapeFactory;

	private List<JsonConverter> converters = new List<JsonConverter> { (JsonConverter)(object)MvcHtmlStringJsonConverter.Instance };

	public NotifyFilter(INotifier notifier, IWorkContextAccessor workContextAccessor, IShapeFactory shapeFactory)
	{
		_notifier = notifier;
		_workContextAccessor = workContextAccessor;
		_shapeFactory = shapeFactory;
	}

	public void OnActionExecuting(ActionExecutingContext filterContext)
	{
	}

	public void OnActionExecuted(ActionExecutedContext filterContext)
	{
		if (((ControllerContext)filterContext).get_IsChildAction() || !_notifier.List().Any())
		{
			return;
		}
		TempDataDictionary tempData = ((ControllerContext)filterContext).get_Controller().get_TempData();
		List<KeyValuePair<NotifyType, MvcHtmlString>> list = new List<KeyValuePair<NotifyType, MvcHtmlString>>();
		if (tempData.ContainsKey("messages"))
		{
			List<KeyValuePair<NotifyType, MvcHtmlString>> list2 = ClassSerializationHelper.DeserializeObjectByJsonNet<List<KeyValuePair<NotifyType, MvcHtmlString>>>(tempData.get_Item("messages").ToString(), converters);
			if (list2 != null)
			{
				list.AddRange(list2);
			}
		}
		foreach (NotifyEntry item in _notifier.List())
		{
			list.Add(new KeyValuePair<NotifyType, MvcHtmlString>(item.Type, item.MvcStringMessage));
		}
		tempData.set_Item("messages", (object)ClassSerializationHelper.SerializeObjectByJsonNet(list, converters));
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		ActionResult result = filterContext.get_Result();
		ViewResultBase val = (ViewResultBase)(object)((result is ViewResultBase) ? result : null);
		if (val == null || !val.get_TempData().ContainsKey("messages"))
		{
			return;
		}
		List<KeyValuePair<NotifyType, MvcHtmlString>> list = ClassSerializationHelper.DeserializeObjectByJsonNet<List<KeyValuePair<NotifyType, MvcHtmlString>>>(val.get_TempData().get_Item("messages").ToString(), converters);
		if (list == null)
		{
			return;
		}
		List<NotifyEntry> list2 = new List<NotifyEntry>();
		foreach (KeyValuePair<NotifyType, MvcHtmlString> item in list)
		{
			if (item.Value != null)
			{
				list2.Add(new NotifyEntry
				{
					Type = item.Key,
					MvcStringMessage = item.Value
				});
			}
		}
		if (list2.Count == 0)
		{
			return;
		}
		dynamic val2 = _workContextAccessor.GetContext((ControllerContext)(object)filterContext).Layout.Zones["Messages"];
		foreach (NotifyEntry item2 in list2)
		{
			val2 = val2.Add(_shapeFactory.Message(item2));
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
