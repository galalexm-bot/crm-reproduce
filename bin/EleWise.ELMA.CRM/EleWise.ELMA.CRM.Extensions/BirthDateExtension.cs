using System;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Extensions;

public static class BirthDateExtension
{
	public static string BirthDate(int? year, int? month, int? day)
	{
		if (year.HasValue && (year < 1 || year > 9999))
		{
			year = null;
		}
		if (month.HasValue && (month < 1 || month > 12))
		{
			month = null;
		}
		if (day.HasValue && (day < 1 || day > DateTime.DaysInMonth(year ?? 1, month ?? 1)))
		{
			day = null;
		}
		DateTime dateTime = new DateTime(year ?? 1, month ?? 1, day ?? 1);
		if (month.HasValue || day.HasValue || year.HasValue)
		{
			return dateTime.ToString((!day.HasValue) ? ((!month.HasValue) ? (year.HasValue ? SR.T("yyyy год") : "") : (year.HasValue ? SR.T("MMMM yyyy года") : SR.T("MMMM"))) : ((!month.HasValue) ? (year.HasValue ? SR.T("d числа yyyy года") : SR.T("d числа")) : (year.HasValue ? SR.T("d MMMM yyyy года") : SR.T("d MMMM"))));
		}
		return "";
	}

	public static string BirthDate(this IContact contact)
	{
		if (contact == null)
		{
			return "";
		}
		return BirthDate((int?)contact.Year, (int?)contact.Month, (int?)contact.Day);
	}
}
