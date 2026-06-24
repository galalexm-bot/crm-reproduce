using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class EmployeesListController : BPMController<IUser, long>
{
	public ActionResult EmployeesListPortlet(EmployeesListPortletPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)settings);
	}

	public ActionResult BirthdayEmployeesList(EmployeesBirthdaysOutputMode mode, bool notDataView)
	{
		bool toBeforeTheYearOnly = false;
		DateTime viewToDate = DateTime.Today;
		switch (mode)
		{
		case EmployeesBirthdaysOutputMode.Today:
			viewToDate = viewToDate.AddDays(1.0);
			break;
		case EmployeesBirthdaysOutputMode.WeekAhead:
			viewToDate = viewToDate.AddDays(7.0);
			break;
		case EmployeesBirthdaysOutputMode.MonthAhead:
			viewToDate = viewToDate.AddMonths(1);
			break;
		case EmployeesBirthdaysOutputMode.BeforeTheYear:
			viewToDate = viewToDate.AddYears(1);
			toBeforeTheYearOnly = true;
			break;
		}
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.Query = "NOT Status = 1";
		List<IUser> list = (from u in Locator.GetServiceNotNull<UserManager>().Find(userFilter, FetchOptions.All)
			where IsViewUser(u.BirthDate, viewToDate, toBeforeTheYearOnly)
			select u).ToList();
		list.Sort((IUser u1, IUser u2) => GetNowYearBirthDate(u1.BirthDate.Value).CompareTo(GetNowYearBirthDate(u2.BirthDate.Value)));
		return (ActionResult)(object)((Controller)this).PartialView((object)new BirthdayEmployeesModel
		{
			Employees = list,
			NotDataView = notDataView
		});
	}

	public ActionResult NewEmployeesList(EmployeesEmployDateOutputMode mode, bool notDataView)
	{
		DateTime value = DateTime.Today;
		switch (mode)
		{
		case EmployeesEmployDateOutputMode.DayBehind:
			value = value.AddDays(-1.0);
			break;
		case EmployeesEmployDateOutputMode.WeekBehind:
			value = value.AddDays(-7.0);
			break;
		case EmployeesEmployDateOutputMode.MonthBehind:
			value = value.AddMonths(-1);
			break;
		case EmployeesEmployDateOutputMode.AfterTheYear:
			value = new DateTime(DateTime.Now.Year, 1, 1);
			break;
		}
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.Query = "NOT Status = 1";
		userFilter.EmployDate = new DateTimeRange(value, DateTime.Now);
		List<IUser> employees = Locator.GetServiceNotNull<UserManager>().Find(userFilter, new FetchOptions(0, 0, ListSortDirection.Descending, "EmployDate")).ToList();
		return (ActionResult)(object)((Controller)this).PartialView((object)new BirthdayEmployeesModel
		{
			Employees = employees,
			NotDataView = notDataView
		});
	}

	public static DateTime GetNowYearBirthDate(DateTime date, bool nowYearOnly = false)
	{
		DateTime dateTime = date.Date.AddYears(DateTime.Today.Year - date.Date.Year);
		if (dateTime < DateTime.Today && !nowYearOnly)
		{
			dateTime = date.Date.AddYears(DateTime.Today.Year - date.Date.Year + 1);
		}
		return dateTime;
	}

	private bool IsViewUser(DateTime? birthday, DateTime rightDate, bool nowYearOnly)
	{
		if (birthday.HasValue)
		{
			DateTime nowYearBirthDate = GetNowYearBirthDate(birthday.Value, nowYearOnly);
			if (nowYearBirthDate >= DateTime.Today)
			{
				return nowYearBirthDate < rightDate;
			}
			return false;
		}
		return false;
	}
}
