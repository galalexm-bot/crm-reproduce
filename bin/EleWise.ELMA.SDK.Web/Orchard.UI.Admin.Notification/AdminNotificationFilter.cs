using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Orchard.DisplayManagement;
using Orchard.Mvc.Filters;
using Orchard.UI.Notify;

namespace Orchard.UI.Admin.Notification;

public class AdminNotificationFilter : FilterProvider, IResultFilter
{
	private readonly INotificationManager _notificationManager;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly dynamic _shapeFactory;

	public AdminNotificationFilter(INotificationManager notificationManager, IWorkContextAccessor workContextAccessor, IShapeFactory shapeFactory)
	{
		_notificationManager = notificationManager;
		_workContextAccessor = workContextAccessor;
		_shapeFactory = shapeFactory;
	}

	public void OnResultExecuting(ResultExecutingContext filterContext)
	{
		if (!AdminFilter.IsApplied(((ControllerContext)filterContext).get_RequestContext()) || !(filterContext.get_Result() is ViewResultBase) || ((ControllerContext)filterContext).get_IsChildAction())
		{
			return;
		}
		List<NotifyEntry> list = _notificationManager.GetNotifications().ToList();
		if (!list.Any())
		{
			return;
		}
		dynamic val = _workContextAccessor.GetContext((ControllerContext)(object)filterContext).Layout.Zones["Messages"];
		foreach (NotifyEntry item in list)
		{
			val = val.Add(_shapeFactory.Message(item));
		}
	}

	public void OnResultExecuted(ResultExecutedContext filterContext)
	{
	}
}
