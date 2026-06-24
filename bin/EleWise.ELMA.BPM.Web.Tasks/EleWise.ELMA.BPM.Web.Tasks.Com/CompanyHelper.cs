using System;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public class CompanyHelper
{
	public static DateTime PreviousPeriod(DateTime period)
	{
		if (period.Month == 1)
		{
			return new DateTime(period.Year - 1, 12, 1);
		}
		return period.AddMonths(-1);
	}

	public static DateTime NextPeriod(DateTime period)
	{
		if (period.Month == 12)
		{
			return new DateTime(period.Year + 1, 1, 1);
		}
		return period.AddMonths(1);
	}

	public static long Count(SearchType searchType, DateTime? period = null)
	{
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		userFilter.ShowBlock = false;
		userFilter.ShowOnlySubordinateAndSelf = searchType == SearchType.Department;
		if (searchType == SearchType.New && period.HasValue)
		{
			DateTime dateTime = ((period.Value.Year == DateTime.Now.Year && period.Value.Month == DateTime.Now.Month) ? period.Value.AddMonths(-1) : period.Value);
			userFilter.EmployDate = new DateTimeRange(new DateTime(dateTime.Year, dateTime.Month, 1, 0, 0, 0), new DateTime(period.Value.Year, period.Value.Month, DateTime.DaysInMonth(period.Value.Year, period.Value.Month), 23, 59, 59));
		}
		if (searchType == SearchType.BirthDays)
		{
			userFilter.YearlyBirthDate = new DateTimeRange
			{
				From = DateTime.Today,
				To = DateTime.Today.AddMonths(1)
			};
			return UserManager.Instance.Count(userFilter);
		}
		return UserManager.Instance.Count(userFilter);
	}

	public static bool IsViewUser(DateTime? birthday, DateTime rightDate)
	{
		if (birthday.HasValue)
		{
			DateTime nowYearBirthDate = GetNowYearBirthDate(birthday.Value);
			if (nowYearBirthDate >= DateTime.Today)
			{
				return nowYearBirthDate < rightDate;
			}
			return false;
		}
		return false;
	}

	public static DateTime GetNowYearBirthDate(DateTime date)
	{
		return date.Date.AddYears(DateTime.Today.Year - date.Date.Year);
	}
}
