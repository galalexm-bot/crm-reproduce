using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.SalesPlan;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class SalesPlanController : BPMController<IPayment, long>
{
	private int GetCalendarModeState(int mode)
	{
		string id = "SalesPlanCalendarMode";
		if (mode == 0)
		{
			return StateExtensions.LoadState<MenuState>(id)?.Width ?? 1;
		}
		StateExtensions.SaveState(id, new MenuState
		{
			Width = mode
		});
		return mode;
	}

	private DateTime GetCalendarStartDate(DateTime? startDate)
	{
		string id = "SalesPlanCalendarStartDate";
		if (!startDate.HasValue)
		{
			MenuState menuState = StateExtensions.LoadState<MenuState>(id);
			if (menuState == null)
			{
				return DateTime.Today;
			}
			return DateTime.Parse(menuState.Id);
		}
		StateExtensions.SaveState(id, new MenuState
		{
			Id = startDate.Value.ToString()
		});
		return startDate.Value;
	}

	public ActionResult Index(int mode = 0)
	{
		mode = GetCalendarModeState(mode);
		DateTime calendarStartDate = GetCalendarStartDate(null);
		List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
		List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).View((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
	}

	public ActionResult SalesPlan(int mode = 0)
	{
		mode = GetCalendarModeState(mode);
		DateTime calendarStartDate = GetCalendarStartDate(null);
		List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
		List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).PartialView((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
	}

	public ActionResult Calendar(int mode = 0)
	{
		mode = GetCalendarModeState(mode);
		DateTime calendarStartDate = GetCalendarStartDate(null);
		List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
		List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).PartialView((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
	}

	public ActionResult CalendarToday()
	{
		int calendarModeState = GetCalendarModeState(0);
		DateTime calendarStartDate = GetCalendarStartDate(DateTime.Today);
		List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(calendarModeState));
		List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate, sales, actualPayments));
	}

	public ActionResult CalendarPrev(DateTime startDate)
	{
		int calendarModeState = GetCalendarModeState(0);
		DateTime calendarStartDate = GetCalendarStartDate(startDate.AddMonths(-1 * calendarModeState));
		PaymentManager.Instance.GetActualPayments(startDate, startDate.AddMonths(calendarModeState));
		SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate));
	}

	public ActionResult CalendarNext(DateTime startDate)
	{
		int calendarModeState = GetCalendarModeState(0);
		DateTime calendarStartDate = GetCalendarStartDate(startDate.AddMonths(calendarModeState));
		PaymentManager.Instance.GetActualPayments(startDate, startDate.AddMonths(calendarModeState));
		SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
		return (ActionResult)(object)((Controller)this).PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate));
	}

	public ActionResult WeekDays(DateTime startDate)
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		DateTime item;
		if (currentCulture.Calendar.GetDayOfWeek(startDate) == DayOfWeek.Monday)
		{
			item = startDate;
		}
		else
		{
			int num = (int)(((currentCulture.Calendar.GetDayOfWeek(startDate) != 0) ? currentCulture.Calendar.GetDayOfWeek(startDate) : ((DayOfWeek)7)) - 1);
			item = startDate.AddDays(-1 * num);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Days", (object)new Tuple<int, DateTime>(7, item));
	}

	public ActionResult Move(long id, string date, int dayNum)
	{
		PaymentManager instance = PaymentManager.Instance;
		IPayment payment = instance.Load(id);
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		DateTime newDate = DateTime.ParseExact(date, "yyyyMMdd", invariantCulture);
		if (dayNum > 1)
		{
			newDate = newDate.AddDays(dayNum - 1);
		}
		instance.ChangeDate(payment, newDate);
		return null;
	}

	public ActionResult ChangeStatus(long id, int status)
	{
		PaymentManager instance = PaymentManager.Instance;
		IPayment payment = instance.Load(id);
		instance.ChangeStatus(payment, (PaymentStatus)status);
		return null;
	}

	public ActionResult ChangeSum(long id, long sum)
	{
		PaymentManager instance = PaymentManager.Instance;
		IPayment payment = instance.Load(id);
		instance.ChangeSum(payment, sum);
		return null;
	}

	public ActionResult CreatePayment(long id, string date, int dayNum, string name, long sum)
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		DateTime paymentDate = DateTime.ParseExact(date, "yyyyMMdd", invariantCulture);
		if (dayNum > 1)
		{
			paymentDate = paymentDate.AddDays(dayNum - 1);
		}
		IPayment payment = PaymentManager.Instance.Create();
		payment.Name = name;
		payment.Sum = sum;
		payment.Sale = SaleManager.Instance.Load(id);
		payment.PaymentStatus = PaymentStatus.Planned;
		payment.PaymentDate = paymentDate;
		payment.Save();
		return null;
	}
}
