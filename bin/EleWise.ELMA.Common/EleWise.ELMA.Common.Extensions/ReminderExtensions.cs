using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Common.Extensions;

public static class ReminderExtensions
{
	public static string GetRemindString(this IReminder reminder)
	{
		if (reminder.RemindTo == TimeSpan.Zero)
		{
			return string.Empty;
		}
		List<string> list = new List<string>();
		int num = Convert.ToInt32(reminder.RemindTo.TotalMinutes);
		if (num % 60 > 0 || num == 0)
		{
			list.Insert(0, SR.T("{0} мин", num % 60));
		}
		num /= 60;
		if (num % 24 > 0)
		{
			list.Insert(0, SR.T("{0} ч", num % 24));
		}
		num /= 24;
		if (num % 7 > 0)
		{
			list.Insert(0, SR.T("{0} дн.", num % 7));
		}
		num /= 7;
		if (num > 0)
		{
			list.Insert(0, SR.T("{0} нед.", num));
		}
		return string.Join(" ", list.ToArray());
	}
}
