using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.KPI.Common.Utils;

public static class PeriodUtils
{
	public static readonly string GlobalPeriodKey = "KPIMBaseTimePeriod";

	public static readonly string GlobalPeriodicityKey = "KPIMBasePeriodicity";

	public static TimePeriod GetCurrentPeriod(HttpContext context)
	{
		if (context == null)
		{
			return null;
		}
		try
		{
			SessionVars.TryGetValue<TimePeriod>(GlobalPeriodKey, out var value);
			return value;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
		}
		return null;
	}

	public static Pair<DateTime, DateTime> GetCurrentPeriod(HtmlHelper helper)
	{
		if (helper == null)
		{
			return null;
		}
		ControllerBase controller = ((ControllerContext)helper.get_ViewContext()).get_Controller();
		if (controller == null)
		{
			return null;
		}
		Type type = ((object)controller).GetType();
		object obj = null;
		string text = "GetCurrentPeriod";
		try
		{
			obj = type.InvokeMember(text, BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, controller, null);
		}
		catch (Exception exception)
		{
			Logger.Log.Error($"Не удалось получить метод BaseController'а {text}", exception);
		}
		return obj as Pair<DateTime, DateTime>;
	}
}
